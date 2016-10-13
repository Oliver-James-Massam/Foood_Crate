    function onSuccess(googleUser) {
        console.log('Logged in as: ' + googleUser.getBasicProfile().getName());
    }

    function onFailure(error) {
        console.log(error);
    }

    function renderButton() {
        gapi.signin2.render('btnGoogle', {
            'scope': 'profile email',
            'width': 200,
            'height': 35,
            'longtitle': true,
            'theme': 'light',
            'onsuccess': onSuccess,
            'onfailure': onFailure
        });
    }

    onload.renderButton();
