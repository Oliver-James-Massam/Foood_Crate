    function onSuccess(googleUser) {
        console.log('Logged in as: ' + googleUser.getBasicProfile().getName());
    }

    function onFailure(error) {
        console.log(error);
    }

    function renderButton() {
        gapi.signin2.render('g-signin2', {
            'scope': 'profile email',
            'width': 100,
            'height': 30,
            'longtitle': false,
            'theme': 'light',
            'onsuccess': onSuccess,
            'onfailure': onFailure
        });
    }
