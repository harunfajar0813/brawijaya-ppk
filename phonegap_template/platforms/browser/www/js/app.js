var Application = {
    showLoading: function (on) {
        setTimeout(function () {
            if (on) {
                $.mobile.loading('show', {
                    text: 'Sedang memuat data...',
                    textVisible: true
                });
            } else {
                $.mobile.loading('hide');
            }
        }, 1);
    },
    login: function () {
        let usernameValue = $('#username').val();
        let passwordValue = $('#password').val();

        $.ajax({
            url: 'https://api.myjson.com/bins/12xmla',
            type: 'GET',
            beforeSend: function () {
                Application.showLoading(true);
            },
            success: function (usersData) {
                let foundUser = usersData.find((userData) => userData.Username === usernameValue && userData.Password === passwordValue);
                if (foundUser) {
                    window.location.href = '#page-two';
                } else {
                    $('#error_field').html('Username dan password salah');
                }
                Application.showLoading(false);
            }
        });
    },
    convert: function () {
        let masukan = $('#masukan').val();
        let sisa = masukan;
        let hasil = '';
        while (sisa != 0) {
            if (sisa >= 500) {
                let floored = Math.floor(sisa / 500);
                hasil += floored + " rim";
                sisa -= floored * 500;
            } else if (sisa >= 144) {
                let floored = Math.floor(sisa / 144);
                hasil += floored + " gross";
                sisa -= floored * 144;
            } else if (sisa >= 20) {
                let floored = Math.floor(sisa / 20);
                hasil += floored + " kodi";
                sisa -= floored * 20;
            } else if (sisa >= 12) {
                let floored = Math.floor(sisa / 12);
                hasil += floored + " lusin";
                sisa -= floored * 12;
            } else {
                hasil += sisa + " buah";
                sisa = 0;
            }
            if (sisa != 0) {
                hasil += ", ";
            }
        }
        $('#hasil_konversi').html(hasil);
    }
};

$('#masukan').on('input', () => Application.convert());
