let recorder; // globally accessible
let userStream;
let _bData = [];
let _oData = [];
let _Route = "";

const dvPlan = "#dvListPlan";
const video01 = document.getElementById('video01');
const canvas01 = document.getElementById('canvas01');
const btnStartRec = document.getElementById('btn-start-recording');
const btnStopRec = document.getElementById('btn-stop-recording');
const btnPauseRec = document.getElementById('btn-pause-recording');
const btnSaveRec = document.getElementById('btn-save-recording');
const btnSaveText = document.getElementById('btn-save-text');
const btnSaveFile = document.getElementById('btn-save-file');

const GetJSONFromArray = function (arrJson, key, val) {
    for (var i in arrJson) {
        if (arrJson[i][key] == val) return arrJson[i];
    }
};

function htmlDecode(input){
  var e = document.createElement('textarea');
  e.innerHTML = input;
  // handle case of empty input
  return e.childNodes.length === 0 ? "" : e.childNodes[0].nodeValue;
}

const hasGetUserMedia = function () {
    // Note: Opera is unprefixed.
    let _r = !!(navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || navigator.msGetUserMedia);
    return _r;
};

let objRes = false;

const checkSupportRTC = function () {

    navigator.mediaDevices.getUserMedia({
        audio: true,
        video: true
    }).then(function (stream) {

        var checkRecorder = RecordRTC(stream, {
            recorderType: MediaStreamRecorder,
            mimeType: 'video/webm', //'video/webm;codecs=vp8',
            timeSlice: 1, // milliseconds, pass this parameter
            frameRate: 1, //15, // used by WebAssemblyRecorder
            bitrate: 1, // 64000
            disableLogs: true,
        });

        objRes = true;

        checkRecorder.startRecording();

        // release camera on stopRecording
        checkRecorder.camera = stream;

        checkRecorder.camera.stop();

    }).catch(function (error) {
        objRes = false;
        toastr.warning("Unable to capture your camera. " + error);
    });

};

$(document).ready(function (e) {

    console.log(1);

    checkSupportRTC();
    InitWebRTC();

    _Route = (window.location.href.toLowerCase().indexOf("interview")) > -1 ? "/Interview" : (window.location.href.toLowerCase().indexOf("technical")) ? "/Technical" : "";
    getListPlan(dvPlan);

    if (_Route == "/Technical") {

        btnSaveFile.onclick = function () {

            if ($('#flAttach')[0].files.length > 0) {

                let _formData = new FormData();
                _formData.append('_d', $('#flAttach')[0].files[0]);
                _formData.append('_n', $('#flAttach')[0].files[0].name);

                let _dt = $("#spnQst").data("data");
                let _qID = _dt.QID;
                let _sID = _dt.SID;

                _formData.append('_q', _qID);
                _formData.append('_s', _sID);

                $.ajax({
                    url: _Route + "/SaveFile",
                    type: 'POST',
                    data: _formData,
                    processData: false,  // tell jQuery not to process the data
                    contentType: false,  // tell jQuery not to set contentType
                    success: function (response) {

                        let oRes = JSON.parse(response);

                        if (oRes.status == "1") {
                            toastr.success("Data berhasil disimpan.");
                        }
                        else {
                            toastr.warning("Data tidak berhasil disimpan.");
                        }

                    },
                    error: function (xhr, status) {

                        console.log(xhr);

                    }
                });

            }


        };
    }
});

function InitWebRTC() {

    btnStartRec.disabled = true;
    btnStopRec.disabled = true;
    btnPauseRec.disabled = true;
    btnSaveRec.disabled = true;

    btnStartRec.classList.add("hide");
    btnStopRec.classList.add("hide");
    btnPauseRec.classList.add("hide");
    btnSaveRec.classList.add("hide");

    if (hasGetUserMedia()) {

        //btnStartRec.style.display = "block";
        btnStartRec.disabled = false;
        btnStopRec.disabled = true;
        btnPauseRec.disabled = true;
        btnSaveRec.disabled = true;

        btnStartRec.classList.remove("hide");
        btnStopRec.classList.add("hide");
        btnPauseRec.classList.add("hide");
        btnSaveRec.classList.add("hide");

        window.URL = window.URL || window.webkitURL;
        navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia || navigator.msGetUserMedia;

        if (objRes) {


        }


        // Good to go!
    } else {

        btnStartRec.disabled = true;
        btnStopRec.disabled = true;
        btnPauseRec.disabled = true;
        btnSaveRec.disabled = true;

        btnStartRec.classList.add("hide");
        btnStopRec.classList.add("hide");
        btnPauseRec.classList.add("hide");
        btnSaveRec.classList.add("hide");

        //alert("Get user media is not supported in your browser.");
        toastr.warning("Get user media is not supported in your browser.");
    }

}

let _Pause = false;
let _Stop = false;

function ProgressCountdown(timeleft, bar, text) {

    return new Promise((resolve, reject) => {

        var countdownTimer = setInterval(() => {

            if (!_Pause) {

                timeleft--;

                document.getElementById(bar).value = timeleft;
                document.getElementById(text).textContent = timeleft;

                if (timeleft <= 0) {
                    //alert(1);
                    btnStopRec.click();
                    clearInterval(countdownTimer);
                    resolve(true);
                }

            }

            if (_Stop) {

                //alert(2);				
                document.getElementById(bar).value = timeleft;
                document.getElementById(text).textContent = timeleft;
                //btnStopRec.click();
                clearInterval(countdownTimer);
                resolve(true);
            }

        }, 1000);
    });

}



btnStartRec.onclick = function () {

    if (!objRes) return;

    btnStartRec.disabled = true;
    btnStopRec.disabled = false;
    btnPauseRec.disabled = false;
    btnSaveRec.disabled = true;

    btnStartRec.classList.remove("hide");
    btnStopRec.classList.remove("hide");
    btnPauseRec.classList.remove("hide");
    btnSaveRec.classList.add("hide");

    let _dt = $("#spnQst").data("data");

    $("#prgCountDown").attr("value", _dt.Duration);
    $("#prgCountDown").attr("max", _dt.Duration);


    captureCamera(function (stream) {

        video01.srcObject = stream;

        userStream = stream;

        recorder = RecordRTC(stream, {
            recorderType: MediaStreamRecorder,
            mimeType: 'video/webm', //'video/webm;codecs=vp8',
            timeSlice: 1000, // milliseconds, pass this parameter
            frameRate: 30, //15, // used by WebAssemblyRecorder
            bitrate: 128000, // 64000
            disableLogs: true,
        });

        (function looper() {
            if (!recorder) {
                return;
            }

            var internal = recorder.getInternalRecorder();
            if (internal && internal.getArrayOfBlobs) {
                var blob = new Blob(internal.getArrayOfBlobs(), {
                    type: 'video/webm'
                });

                //document.querySelector('h1').innerHTML = 'Recording length: ' + bytesToSize(blob.size);
                document.getElementById("prevBlob").textContent = bytesToSize(blob.size);
            }

            setTimeout(looper, 1000);

        })();

        recorder.startRecording();

        // release camera on stopRecording
        recorder.camera = stream;

        _Pause = false;
        _Stop = false;

        ProgressCountdown(_dt.Duration, "prgCountDown", "prevCountDown").then(value => console.log("Video ended."));

        $("#infoRecord").show();

    });

};

btnStopRec.onclick = function () {

    if (!objRes) return;

    btnStartRec.disabled = false;
    btnStopRec.disabled = true;
    btnPauseRec.disabled = true;
    btnSaveRec.disabled = false;

    btnStartRec.classList.remove("hide");
    btnStopRec.classList.remove("hide");
    btnPauseRec.classList.remove("hide");
    btnSaveRec.classList.remove("hide");

    if (!recorder) {
        return;
    }

    var internal = recorder.getInternalRecorder();

    if (internal && internal.getArrayOfBlobs) {

        var blob = new Blob(internal.getArrayOfBlobs(), {
            type: 'video/webm'
        });

        let cvs = document.getElementById("cvs");
        cvs.height = video01.videoHeight;
        cvs.width = video01.videoWidth;

        let context = cvs.getContext('2d');
        context.drawImage(video01, 0, 0, cvs.width, cvs.height);



        //document.querySelector('h1').innerHTML = 'Recording length: ' + bytesToSize(blob.size);
        document.getElementById("prevBlob").textContent = 'Recording length: ' + bytesToSize(blob.size);
    }

    recorder.stopRecording(stopRecordingCallback);

    _Pause = false;
    _Stop = true;

};

const CancelRecording = function () {

    if (!recorder) {
        return;
    }

    recorder.camera.stop();
    recorder = null;

    _bData = [];

};


btnPauseRec.onclick = function () {

    if (!objRes) return;

    btnStartRec.disabled = true;
    btnStopRec.disabled = false;
    btnPauseRec.disabled = false;
    btnSaveRec.disabled = true;

    //if (this.innerHTML === 'Pause Recording') {
    if (!_Pause) {
        recorder.pauseRecording();
        _Pause = true;
        //this.innerHTML = 'Resume Recording';
    }
    else {
        recorder.resumeRecording();
        _Pause = false;
        //this.innerHTML = 'Pause Recording';
    }
    /*
	setTimeout(function () {
		document.getElementById('btn-pause-recording').disabled = false;
	}, 2000);
	*/
};

btnSaveRec.onclick = function () {

    if (!objRes) return;

    let _cbxId = 0;

    //if (video01.src != "") {
    if (_bData.length > 0) {

        if ($(".cbx-img:checked").length != 1) {
            //alert("Thumbnail belum dipilih");
            toastr.warning("Tidak bisa menyimpan video, karena pilihan video belum dipilih.");
            return;
        }

        $(".cbx-img:checked").each(function () {
            _cbxId = $(this).attr("id").replace("cbx-", "");

        });

        //Generating a random file name
        let _fn = getFileName('webm');

        // we need to upload "File" --- not "Blob"
        let _fOb = new File([_bData[_cbxId - 1]], _fn, {
            type: 'video/webm'
        });

        let _dt = $("#spnQst").data("data");
        let _qID = _dt.QID;
        let _sID = _dt.SID;

        var formData = new FormData();

        //Recorded data
        formData.append('_d', _fOb); //_fOb
        formData.append('_n', _fn);
        //File name
        //formData.append('id', 1);
        formData.append('_q', _qID);
        formData.append('_s', _sID);
        //formData.append('name', _fOb.name);
        //formData.append('mode', "save");

        //Upload using jQuery
        $.ajax({
            url: _Route + "/Save", // replace with your own server URL
            data: formData,
            cache: false,
            contentType: false,
            processData: false,
            async: false,
            type: 'POST',
            xhr: function () {

                $("#loading").show();

                var xhr = new window.XMLHttpRequest();

                xhr.upload.addEventListener("progress", function (evt) {

                    if (evt.lengthComputable) {
                        var percentComplete = evt.loaded / evt.total;
                        percentComplete = parseInt(percentComplete * 100);

                        console.log(percentComplete);

                        if (percentComplete === 100) {

                        }

                    }
                }, false);

                return xhr;
            },
            success: function (response) {

                let oRes = JSON.parse(response);

                if (oRes.status == "1") {

                    let videoTrack = userStream.getVideoTracks();

                    if (videoTrack.length > 0) {

                        for (var i = 0; i < videoTrack.length; i++) {
                            userStream.removeTrack(videoTrack[i]);
                            video01.src = "";
                        }

                        userStream = null;
						_bData = [];
                    }

                    video01.src = oRes.url;
                    toastr.success("Video berhasil disimpan.");

                    $("#dvThumbnails").empty();

                    btnStartRec.disabled = false;
                    btnStopRec.disabled = true;
                    btnPauseRec.disabled = true;
                    btnSaveRec.disabled = true;

                    btnStartRec.classList.remove("hide");
                    btnStopRec.classList.add("hide");
                    btnPauseRec.classList.add("hide");
                    btnSaveRec.classList.add("hide");

                }
                else {
                    toastr.warning("Terjadi kegagalan dalam penyimpanan video.");
                }

            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert(xhr.status);
                alert(thrownError);
            }
        });


    }


};

btnSaveText.onclick = function () {

    if (!objRes) return;

    let _sAnswer = $("#txtAnswer").val();
    let _data = $("#spnQst").data("data");

    if (_sAnswer.trim() == "") {
        toastr.warning("Jawaban belum diisi.");
        //return;
    }

    $.ajax({
        type: "POST",
        url: _Route + "/Save",
        data: {
            "_d": _sAnswer,
            "_q": _data.QID,
            "_s": _data.SID
        },
        dataType: "json",
        async: false,
        success: function (response) {
            let oRes = JSON.parse(response);

            if (oRes.status == "1") {
                toastr.success("Data berhasil disimpan.");
            }
            else {
                toastr.warning("Data tidak berhasil disimpan.");
            }
        },
        error: function (xhr, status) {
            console.log(xhr);
        }
    });

};




function getFileName(fileExtension) {
    var d = new Date();
    var year = d.getUTCFullYear();
    var month = d.getUTCMonth();
    var date = d.getUTCDate();
    return 'RecordRTC-' + year + month + date + '-' + getRandomString() + '.' + fileExtension;
}

function getRandomString() {
    if (window.crypto && window.crypto.getRandomValues && navigator.userAgent.indexOf('Safari') === -1) {
        var a = window.crypto.getRandomValues(new Uint32Array(3)),
			token = '';
        for (var i = 0, l = a.length; i < l; i++) {
            token += a[i].toString(36);
        }
        return token;
    } else {
        return (Math.random() * new Date().getTime()).toString(36).replace(/\./g, '');
    }
}

function progressHandlingFunction(e) {
    if (e.lengthComputable) {
        var s = parseInt((e.loaded / e.total) * 100);
    }
}

const getListPlan = function (_dv, _pos) {

    $.ajax({
        type: "GET",
        url: _Route + "/ListPlan",
        dataType: "json",
        async: false,
        success: function (result) {

            _oData = result;

            if (_dv != "undefined") {
                generateListPlan(_dv, _pos);
            }

        },
        error: function (xhr, status) {
            console.log(xhr);
            console.log(status);
        }
    });

};

const generateListPlan = function (_div, _pos) {

    $(_div).html("");
    /*
    let _html =
	"<div class='col-md-12'>\
		<div class='portlet light portlet-fit'>\
			<div class='portlet-title'>\
				<div class='caption'>\
					<h2 style='margin: 0;'>Interview Plan</h2>\
				</div>\
			</div>\
			<div class='m-heading-1 border-green m-bordered' style='margin-bottom: 10px;'>\
			    <ol>\
					<li>Pastikan ada anda mengaktifkan Camera, dan Audio untuk bisa menjawab pertanyaan.</li>\
					<li>Semua pertanyaan harus dijawab dengan baik dan benar, untuk bisa diproses selanjutnya.</li>\
				</ol>\
            </div>\
			<div class='col-sm-8'>"; //portlet-body
	*/
    let _html =	"<div class='col-sm-8' style='padding: 0px'>"; //portlet-body
	let _sTask = "";
	
    if (_oData.length > 0) {
		
		let _showNote = true;
		
        let _link, _l = 0, _n = 0, _style = "";
        let _gData = GroupingJson(_oData);
        let _isExpand, _display;
		
		
        for (var i = 0; i < _gData.length; i++) {

            _l = _gData[i].gdata.length;
            _n = 0;

            for (var x in _gData[i].gdata) {
                if (_gData[i].gdata[x].answer != "" || _gData[i].gdata[x].link != "" || _gData[i].gdata[x].file != "") _n++;
            }

            _isExpand = "expand";
            _display = "none";

            if (!!_pos) {

                if (_pos == _gData[i].gid) {
                    _Route
                    _isExpand = "collapse";
                    _display = "block";
                }

            }


            _sTask +=
			"<div class='portlet box green'>\
				<div class='portlet-title'>\
					<div class='caption'>"+ htmlDecode(_gData[i].gname) + "</div>\
					<div class='tools'>\
						<span>("+ _n + "&nbsp;/&nbsp;" + _l + ") &nbsp;&nbsp;</span>\
						<a href='javascript:;' class='"+ _isExpand + "' data-original-title='' title=''> </a>\
					</div>\
				</div>\
				<div class='portlet-body' style='display: "+ _display + "; padding: 0px;'>\
					<table class='table table-hover table-striped table-bordered' style='margin-bottom: 0px'>\
						<tbody>";
			
			if(_n != _l) _showNote = false;
			
            for (var j = 0; j < _gData[i].gdata.length; j++) {

                var _d = _gData[i].gdata[j];
				/*
                _sTask +=
				"<tr>\
					<td style='width:80%;'>"+ (j + 1) + ". " + htmlDecode(_d.name) + "</td>\
					<td style='text-align:center;'>\
						<input type='hidden' id='drs_"+ _d.tid + "' value='" + _d.duration + "' />";
				*/
				
				_sTask +=
				"<tr>\
					<td style='width:80%;'>"+ htmlDecode(_d.name) + "</td>\
					<td style='text-align:center;'>\
						<input type='hidden' id='drs_"+ _d.tid + "' value='" + _d.duration + "' />";
				
                //_link = (_d.type == "video") ? "<i class='fa fa-video-camera' aria-hidden='true' style='color:#EF5350;'></i>" : "<i class='fa fa-file-text-o' aria-hidden='true' style='color:#000000;'></i>";
                _style = "color:#EF5350; font-weight: bold;";

                if (_d.answer != "" || _d.link != "" || _d.file != "") {
                    _style = "color:#00FF00; font-weight: bold;";
                }

                switch (_d.type) {
                    case "video":
                        _link = "<i class='fa fa-video-camera' aria-hidden='true' style='" + _style + "'></i>";
                        break;
                    case "text":
                        _link = "<i class='fa fa-file-text-o' aria-hidden='true' style='" + _style + "'></i>";
                        break;
                    case "attachment":
                        _link = "<i class='fa fa-paperclip' aria-hidden='true' style='" + _style + "'></i>";
                        break;
                    case "dynamic":
                        _link = "<i class='fa fa-paperclip' aria-hidden='true' style='" + _style + "'></i>";
                        break;
                }

                if (_d.answer == "" && _d.link == "" && _d.file == "") {
                    _sTask += "<button type='button' data='" + _d.tid + "' class='btn green btn-outline btn-qst'>Answer &nbsp;&nbsp;" + _link + "</button>";
                }
                else {
                    _sTask += "<button type='button' data='" + _d.tid + "' class='btn green btn-outline btn-qst'>View &nbsp;&nbsp;" + _link + "</button>";
                }

                _sTask += "</td>\
				</tr>";

            }

            _sTask +=
			"		</tbody>\
				</table>\
			</div></div>";

        }
		
		if(_showNote) {			
			let _note = "<div class='note note-info'><strong>Sukses..!&nbsp;</strong>Semua pertanyaan sudah terjawab</div>";
			_html += _note;
		}
    }
    /*
    _html +=
	"		</div>\
		</div>\
	</div>";
	*/
    _html += _sTask + "</div>";

    $(_div).html(_html);

    $(".btn-qst").click(function (e) {

        let _idx = $(this).attr("data");
        let _data = GetJSONFromArray(_oData, "QID", _idx);


        $("#spnQst").html(htmlDecode(_data.Name));
        $('#spnQst').data("data", _data);

        if (_data.QType == "video") {

            if (_Route == "/Interview") {

                $("#dvVideo").hide();
                $("#dvText").hide();
                $("#dvAttachment").hide();

                $("#dvVideo").show();
            }
            else {

                $("#liVideo").show();
                $("#liText").hide();
                $("#liFile").hide();

                $("#dvVideo").hide();
                $("#dvText").hide();
                $("#dvAttachment").hide();

                $("#dvVideo").show();

            }


            btnStartRec.classList.remove("hide");


            $("#prevCountDown").text(_data.Duration);
            $("#prgCountDown").val(_data.Duration);
            $("#prevBlob").text("0");

            if (_data.LinkID != "") {
                $("#infoRecord").hide();
                video01.src = _Route + _data.LinkID;
            }
            else {
                video01.src = "";
                $("#infoRecord").hide();
            }

        }
        else if (_data.QType == "text") {

            if (_Route == "/Interview") {

                $("#dvVideo").hide();
                $("#dvText").hide();
                $("#dvAttachment").hide();

                $("#dvText").show();
            }
            else {

                $("#liVideo").hide();
                $("#liText").show();
                $("#liFile").hide();

                $("#dvVideo").hide();
                $("#dvText").hide();
                $("#dvAttachment").hide();

                $("#dvText").show();

            }

            //$("#dvVideo").hide();
            //$("#dvText").hide();
            //$("#dvAttachment").hide();

            //$("#dvText").show();
            $("#txtAnswer").val(_data.Answer);

        }
        else if (_data.QType == "attachment") {

            //$("#dvVideo").hide();
            //$("#dvText").hide();
            //$("#dvAttachment").hide();

            if (_Route == "/Technical") {

                $("#liVideo").hide();
                $("#liText").hide();
                $("#liFile").show();

                $("#dvVideo").hide();
                $("#dvText").hide();
                $("#dvAttachment").hide();

                $("#dvAttachment").show();

                if (_data.Attachment != "") {

                    $("#dvAttachment").find("a").attr("href", _Route + _data.Attachment);
                    $("#dvAttachment .down").removeClass("hide");
                    $("#dvAttachment .up").removeClass("hide").addClass("hide");

                }
                else {

                    $("#dvAttachment").find("a").attr("href", "");
                    $("#dvAttachment .down").removeClass("hide").addClass("hide");
                    $("#dvAttachment .up").removeClass("hide");

                }

            }




        }
        else if (_data.QType == "dynamic") {

            if (_Route == "/Technical") {

                $("#liVideo").show();
                $("#liText").show();
                $("#liFile").show();

                $("#dvVideo").css("display", "");
                $("#dvText").css("display", "");
                $("#dvAttachment").css("display", "");

                $('.nav-tabs a:first').tab('show');

                if (_data.LinkID != "") {
                    $("#infoRecord").hide();
                    video01.src = _Route + _data.LinkID;
                }
                else {
                    video01.src = "";
                    $("#infoRecord").hide();
                }

                btnStartRec.classList.remove("hide");


                $("#txtAnswer").val(_data.Answer);

                if (_data.Attachment != "") {

                    $("#dvAttachment").find("a").attr("href", _Route + _data.Attachment);
                    $("#dvAttachment .down").removeClass("hide");
                    $("#dvAttachment .up").removeClass("hide").addClass("hide");

                }
                else {

                    $("#dvAttachment").find("a").attr("href", "");
                    $("#dvAttachment .down").removeClass("hide").addClass("hide");
                    $("#dvAttachment .up").removeClass("hide");

                }
            }


        }

        //Comment();

        //alert($(this).attr("data"));
        $("#dvListPlan").hide();
        $("#dvAnswer").show();

    });

};

const GroupingJson = function () {

    let _gData = [];
    let _data;

    for (var i in _oData) {

        _data = {
            "tid": _oData[i].QID,
            "aid": _oData[i].AID,
            "name": _oData[i].Name,
            "type": _oData[i].QType,
            "answer": _oData[i].Answer,
            "link": _oData[i].LinkID,
            "file": _oData[i].Attachment,
            "duration": _oData[i].Duration
        };

        if (_gData.length == 0) {
            _gData.push({ "gid": _oData[i].GID, "gname": _oData[i].Group, "gdata": [] });
            _gData[0].gdata.push(_data);
        }
        else {

            var _idx = parseInt(findIndexInObject(_gData, "gid", _oData[i].GID));

            if (_idx == -1) {

                _gData.push({ "gid": _oData[i].GID, "gname": _oData[i].Group, "gdata": [_data] });
                //_gData[_gData.length].gdata.push(_data);

            }
            else {

                _gData[_idx].gdata.push(_data);

            }
        }

    }

    return _gData;

};


const findIndexInObject = function (_o, _k, _v) {

    for (var i in _o) {
        if (_o[i][_k] == _v) return i;
    }

    return -1;
};

$(".btn-back").click(function (e) {

    let _d = $("#spnQst").data("data");
    let _gid = _d.GID;

    CancelRecording();
    Reset();

    getListPlan(dvPlan, _gid);
    $("#dvListPlan").show();
    $("#dvAnswer").hide();

});

const Reset = function () {

    btnStartRec.disabled = false;
    btnStopRec.disabled = true;
    btnPauseRec.disabled = true;
    btnSaveRec.disabled = true;

    btnStartRec.classList.add("hide");
    btnStopRec.classList.add("hide");
    btnPauseRec.classList.add("hide");
    btnSaveRec.classList.add("hide");

    $("#infoRecord").hide();

    _bData = [];
    _oData = [];
    video01.src = "";
    $("#prevCountDown").text("0");
    $("#prgCountDown").val(0);
    $("#prevBlob").text("0");

    $("#txtAnswer").val("");
    $("#dvThumbnails").empty();
    $("#spnQst").text("");
    $("#spnQst").data("data", {});
};

const captureCamera = function (callback) {
    //'environment'
    navigator.mediaDevices.getUserMedia({
        audio: true,
        //video: true,
        video: { facingMode: 'user' }
    }).then(function (stream) {
        callback(stream);
    }).catch(function (error) {
        //alert('Unable to capture your camera. Please check console logs.');
        toastr.warning('Unable to capture your camera. Please check console logs.');
        console.error(error);
    });

};

const sleep = function (seconds) {
    var waitUntil = new Date().getTime() + seconds * 1000;
    while (new Date().getTime() < waitUntil) true;
};


var createCanvas = function (_id) {


    //if (_bData.length == 0) return;

    //alert(video01.src);

    //let _id = _bData.length;nopad

    let strHtml =
		"<div class='col-xs-4 col-sm-3 col-md-2 text-center thumbnail'>\
			<label class='image-checkbox'>\
				<img class='img-responsives' id='img-"+ _id + "' src='' style='width:50%;'>\
				<input class='cbx-img' id='cbx-"+ _id + "' name='image[]' value='' type='checkbox'>\
				<i class='fa fa-check hidden'></i>\
				<div>Video "+ (_id) + "</div>\
			</label>\
		</div>";

    $("#dvThumbnails").append(strHtml);

    /*
	let cvs = document.getElementById("cvs");
	cvs.height = video01.videoHeight;
	cvs.width = video01.videoWidth;
		
	let _dtImage = cvs.toDataURL('image/png');
	*/
    let photo = document.getElementById("img-" + _id);
    photo.setAttribute('src', cvs.toDataURL('image/png'));


    $(".image-checkbox").unbind().on("click", function (e) {

        if (_bData.length == 0) {
            //alert("There's no video exist.");
            toastr.warning("There's no video exist.");
        }

        $(this).toggleClass('image-checkbox-checked');
        var _checkbox = $(this).find('input[type="checkbox"]');
        var _cbxId = _checkbox.attr("id").replace("cbx-", "");

        $(".cbx-img").each(function () {

            var _id = $(this).attr("id").replace("cbx-", "");

            if (_cbxId != _id) {
                $(this).parent().removeClass('image-checkbox-checked');
                $(this).prop("checked", false);
            }

        });

        _checkbox.prop("checked", !_checkbox.prop("checked"));

        var $image = $(this).find('.img-responsives');
        var _id = $image.attr("id").replace("img-", "");
        video01.src = URL.createObjectURL(_bData[parseInt(_id - 1)]);

        e.preventDefault();

    });

    if (_bData.length == 1) {
        $(".image-checkbox #img-" + parseInt(_id)).click();
    }
    else {
        $(".image-checkbox").each(function (index) {
            if ($(this).hasClass("image-checkbox-checked")) $(this).click();
        });
    }

    return _id;

};

var stopRecordingCallback = function (e) {

    video01.srcObject = null;
    let _blob = recorder.getBlob();
    video01.src = URL.createObjectURL(_blob);

    _bData.push(_blob);

    recorder.camera.stop();
    recorder = null;

    //sleep(1);
    /*
	let cvs = document.getElementById("cvs");
	cvs.height = video01.videoHeight;
	cvs.width = video01.videoWidth;

	let context = cvs.getContext('2d');
	context.drawImage(video01, 0, 0, cvs.width, cvs.height);
	
	cvs.style.display = "block";
		
	let _dataImage = cvs.toDataURL('image/png');
	*/
    createCanvas(_bData.length);

    return;

};
