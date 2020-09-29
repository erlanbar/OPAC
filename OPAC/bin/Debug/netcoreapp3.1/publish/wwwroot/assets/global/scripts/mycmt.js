//$(function () {
	
function Comment() {
	
	if(!$.fn.comments) {
	
		$.fn.comments = function(options) {
			console.log("options", options);
			return this.each(function() {
				console.log("fn.comments");
				var comments = Object.create(Comments);
				$.data(this, 'comments', comments);
				comments.init(options || {}, this);
			});
		};
		
	}

	console.log("Comment");
	
	$('#comments-container').empty();
	$('#comments-container').unbind();
	
	var saveComment = function (data) {
		console.log(data);

		// Convert pings to human readable format
		$(Object.keys(data.pings)).each(function (index, userId) {
			var fullname = data.pings[userId];
			var pingText = "@" + fullname;
			data.content = data.content.replace(new RegExp("@" + userId, 'g'), pingText);
		});
		return data;
	}
	
	$("#comments-container").comments({
		profilePictureURL: '/assets/global/img/user-icon.png',
		currentUserId: 1,
		roundProfilePictures: true,
		textareaRows: 1,
		enableAttachments: false,
		enableHashtags: true,
		enablePinging: false,
		enableNavigation: false,
		enableUpvoting: false,
		searchUsers: function(term, success, error) {
			console.log("searchUsers", term);
			setTimeout(function() {
				success(usersArray.filter(function(user) {
					var containsSearchTerm = user.fullname.toLowerCase().indexOf(term.toLowerCase()) != -1;
					var isNotSelf = user.id != 1;
					return containsSearchTerm && isNotSelf;
				}));
			}, 500);
		},
		getComments: function(success, error) {
			//success(commentsArray);
			setTimeout(function() {
				success(getListComment());
			}, 500);
			
		},
		postComment: function(data, success, error) {
			console.log("postComment", success);
			setTimeout(function() {
				success(saveComment(data));
			}, 500);
		},
		putComment: function(data, success, error) {
			console.log("putComment");
			setTimeout(function() {
				success(saveComment(data));
			}, 500);
		},
		deleteComment: function(data, success, error) {
			console.log("deleteComment");
			setTimeout(function() {
				success();
			}, 500);
		},
		upvoteComment: function(data, success, error) {
			console.log("upvoteComment", data);
			setTimeout(function() {
				success(data);
			}, 500);
		},
		uploadAttachments: function(dataArray, success, error) {
			setTimeout(function() {
				success(dataArray);
			}, 500);
		},
	});

}

const getListComment = function () {
	
	let _x = [];
	let _data = $("#spnQst").data("data");
	
    $.ajax({
        type: "POST",
        url: "/Interview/ListComments",
		data: {
            "_q": _data.QID,
        },
        dataType: "json",
        async: false,
        success: function (result) {
			console.log(result);
        },
        error: function (xhr, status) {
            console.log(xhr);
            console.log(status);
        }
    });
	
	return _x;
};

//});