<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cars</title>
</head>
<body>

    <table>

        <tr>
            <th>Name</th>
            <th>Price</th>
        </tr>
        % for car in cars:
        <tr>
            <td>{{car['name']}}</td>
            <td>{{car['price']}}</td>
        </tr>
        % end

    </table>

</body>
</html>
