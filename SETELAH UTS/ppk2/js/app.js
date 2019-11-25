var dataObject = [
    {
        "nim":"125060400111044",
        "nama": "Isyana Sarasvati",
        "jurusan": "Teknik Informatika",
        "fakultas": "Filkom",
        "alamat": "Jl. Suka Nyanyi",
        "noHP": "081234567890"
    },
    {
        "nim":"135060401111005",
        "nama": "Marion Jola",
        "jurusan": "komunikasi",
        "fakultas": "FISIP",
        "alamat": "Kec. Wakanda",
        "noHP": "08765432109"
    },
    {
        "nim":"185150207111011",
        "nama": "Harun Ulum Fajar",
        "jurusan": "Kedokteran",
        "fakultas": "FK",
        "alamat": "Kec. HIMALAYA",
        "noHP": "08136568599"
    }
];

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
        var output = '';
        $.each(dataObject, function (index, value) {
            output += '<li><a href="#page-two?id=' + value.nim + '" target="_self" id="detail-mhs" data-nimmhs="' + value.nim +'"><h2>' + value.nama + '</h2><p>' + value.nim + '</p><p><b>' + value.fakultas + '</b></p></a></li>';
        });
        $('#list-mhs').append(output);
    },

    initShowDetailMhs : function (nim) {
        var appendDetail = "";
        var tbdy = $("#table-detailMhs tbody");
        for (var i=0;i<dataObject.length;i++){
            if (dataObject[i].nim == nim) {
                tbdy.children().remove();
                if (dataObject[i].nim == nim && tbdy.children().length == 0) {
                    appendDetail = '<tr><td>' + dataObject[i].nim + '</td><td>' + dataObject[i].nama + '</td><td>' + dataObject[i].jurusan + '</td><td>' + dataObject[i].fakultas + '</td><td>' + dataObject[i].alamat + '</td><td>' + dataObject[i].noHP + '</td></tr>';
                    $('#table-detailMhs').append(appendDetail).table("refresh");
                }
            }
        }
    }
};