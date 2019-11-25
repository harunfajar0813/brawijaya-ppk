var Application = {
    initApplication : function () {
        $(window).load('pageinit', "#page-one", function () {
            Application.initShowMhs();
        });
        $(document).on('click', '#detail-mhs', function () {
            var nim = $(this).data('nimmhs');
            Application.initShowDetailMhs(nim);
        });
    },

    initShowMhs : function () {
        $.ajax({
            type : 'GET',
            url : 'https://berhasilmahasiswa.000webhostapp.com/web_service.php',
            beforeSend : function(){
                $.mobile.loading('show', {
                    text : 'Please wait....',
                    textVisible : true
                });
            },
            success : function(dataObject){
                console.log(dataObject);
                var output = '';
                $.each(dataObject, function (index, value) {
                    output += '<li><a href="#page-two?id=' + value.NIM + '" target="_self" id="detail-mhs" data-nimmhs="' + value.NIM +'"><h2>' + value.Nama + '</h2><p>' + value.NIM + '</p><p><b>' + value.Fakultas + '</b></p></a></li>';
                });
                $('#list-mhs').append(output);
                $('#list-mhs').listview('refresh');
            },
            complete : function(){
                $.mobile.loading('hide');
            }
        });
    },

    initShowDetailMhs : function (nim) {
        $.ajax({
            type : 'GET',
            url : 'https://berhasilmahasiswa.000webhostapp.com/web_service.php',
            beforeSend : function(){
                $.mobile.loading('show', {
                    text : 'Please wait....',
                    textVisible : true
                });
            },
            success : function(dataObject){
                for (var i=0;i<dataObject.length;i++){
                    if (dataObject[i].NIM == nim) {
                        $('#p-nim, #p-nama, #p-jurusan, #p-fakultas, #p-alamat, #p-nohp').empty();
                        $('#p-nim').append('<b>NIM: </b>' + dataObject[i].NIM);
                        $('#p-nama').append('<b>Nama: </b>' + dataObject[i].Nama);
                        $('#p-jurusan').append('<b>Jurusan: </b>' + dataObject[i].Jurusan);
                        $('#p-fakultas').append('<b>Fakultas: </b>' + dataObject[i].Fakultas);
                        $('#p-alamat').append('<b>Alamat: </b>' + dataObject[i].Alamat);
                        $('#p-nohp').append('<b>Phone: </b>' + dataObject[i].NoHp);
                    }
                }
                
            },
            complete : function(){
                $.mobile.loading('hide');
            }
        });
    }
};