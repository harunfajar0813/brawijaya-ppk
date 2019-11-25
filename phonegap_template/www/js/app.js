var Application = {
    searchByKK: function () {
        window.location.href = '#page-two'; 
    },
    
    searchByKKResult: function(){
        var nilai = $('#inputKK').val();
        if(!nilai) alert("kosong");
        else{
            $.post( "http://barokah-softdev.com/rest/api/selectbyKK", { no_kk:nilai }).done(function( data ) {
                var dataBaru = JSON.parse(data);
                if (dataBaru.hasOwnProperty('message')) {
                    alert(dataBaru.message);
                } else {
                    var personResult = dataBaru.result
                    $('#id_survey, #nokk, #nama, #alamat, #gambar_ea').empty();
                    $('#id_survey').append("ID : ", personResult.id_survey);
                    $('#nokk').append("KK : ", personResult.nomor_id_bdt);
                    $('#nama').append("Nama : ", personResult.nama_kepala_rumah_tangga);
                    $('#alamat').append("Alamat : ", personResult.alamat_rumah);
                    $('#gambar_ea').attr("src", personResult.image);
                    window.location.href = '#page-two-result'; 
                }
            }).fail(function() {
                alert( "error" );
            });
        }
    },

    searchList : function(){
        window.location.href = '#page-three'; 
    },

    searchListResult : function(){
        var jumlah = $('#jumlahList').val();
        var output = '';
        if(!jumlah) alert("kosong");
        else{
            $.post( "http://barokah-softdev.com/rest/api/getlist", { jml:jumlah }).done(function( data ) {
                var dataBaru = JSON.parse(data);
                if (dataBaru.hasOwnProperty('message')) {
                    alert(dataBaru.message);
                } else {
                    var peopleResult = dataBaru.result;
                    $.each(peopleResult, function (index, value) {
                        output += '<tr>';
                        output += '<td>';
                        output += '<img width="75" height="100" src= "'+value.image+'">';
                        output += '</td>';
                        output += '<td>';
                        output += '<p>ID Survey : '+value.id_survey+'</p>';
                        output += '<p>Nomer KK : '+value.nomor_id_bdt+'</p>';
                        output += '<p>Nama : '+value.nama_kepala_rumah_tangga+'</p>';
                        output += '<p>Alamat : '+value.alamat_rumah+'</p>';
                        output += '</td>';
                        output += '</tr>';
                    });
                    $('#id-searchlist').empty();
                    $('#id-searchlist').append(output);
                    window.location.href = '#page-three-result';
                }
            }).fail(function() {
                alert( "error" );
            });
        }
    }
};