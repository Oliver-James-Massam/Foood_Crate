    function onSuccess(googleUser) {
        console.log('Logged in as: ' + googleUser.getBasicProfile().getName());
    }

    function onFailure(error) {
        console.log(error);
    }

    function renderButton() { // acoorfing to google how to obtain user details
        gapi.signin2.render('gglbtn', {
            'scope': 'profile email',
            'width': 120,
            'height': 35,
            'longtitle': false,
            'theme': 'light',
            'onsuccess': onSuccess,
            'onfailure': onFailure
        });
    }

    onload.renderButton();