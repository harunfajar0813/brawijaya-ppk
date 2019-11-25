<?php
$connect = mysqli_connect("localhost", "root", "", "ppk1");

$result = mysqli_query($connect, "SELECT * FROM mahasiswa");

$json_array = array();

while($row = mysqli_fetch_assoc($result)){
    $json_array[] = $row;
}

header('Content-Type:application/json;charset=utf-8');
echo json_encode( $json_array );
?>