﻿function onSingIn(googleUser) {
    var profile = googleUser.getBasicProfile();
    $(".g-singin2").css("display", "none");
    $(".data").css("display", "block");
    $("#pic").attr('src', profile.getImageUrl());
    $("#name").text(profile.getName());
    $("#email").text(profile.getEmail());


    //
    var Name = profile.getName();
    var Email = profile.getEmail();
    var Img = profile.getImageUrl();
    var userName = JSON.stringify({ Name, Email });
    $.ajax({

        type: 'POST',
        url: 'api/login',
        data: userName,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) { alert("valio"); },

        error: function (msg) {
            alert(msg);
        }
    });


}

function signOut() {
    var auth2 = gapi.auth2.getAuthInstance();
    auth2.signOut().then(function () {
        $(".g-singin2").css("display", "block");
        $(".data").css("display", "none");
        alert("Success");
    });
}
