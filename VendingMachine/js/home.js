$(document).ready(function() {

  loadItems();

  $('#adddolar').on('click', function(){
        const display = document.querySelector('#total');
        const test = +display.value + +1.00;
        display.value = Number(test).toFixed(2);
      });

  $('#addquarter').on('click', function(){
        const display = document.querySelector('#total');
        const test = +display.value + +0.25;
        display.value = Number(test).toFixed(2);
      });

  $('#adddime').on('click', function(){
        const display = document.querySelector('#total');
        const test = +display.value + +0.10;
        display.value = Number(test).toFixed(2);
      });

  $('#addnickel').on('click', function(){
        const display = document.querySelector('#total');
        const test = +display.value + +0.05;
        display.value = Number(test).toFixed(2);
      });

  $('#snickers').on('click', function(){
        const display = document.querySelector('#snickers');
        const item = document.querySelector('#itemDisplay');
        item.value = display.value;
      });

  $('#mandms').on('click', function(){
    const display = document.querySelector('#mandms');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#almondJoy').on('click', function(){
    const display = document.querySelector('#almondJoy');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#milkyWay').on('click', function(){
    const display = document.querySelector('#milkyWay');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#payDay').on('click', function(){
    const display = document.querySelector('#payDay');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#reeses').on('click', function(){
    const display = document.querySelector('#reeses');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#pringles').on('click', function(){
    const display = document.querySelector('#pringles');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#cheezits').on('click', function(){
    const display = document.querySelector('#cheezits');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#doritos').on('click', function(){
    const display = document.querySelector('#doritos');
    const item = document.querySelector('#itemDisplay');
    item.value = display.value;
      });

  $('#makePurchase').on('click', function(){
    purchaseItem();
      });

  $('#changeReturn').on('click', function(){
    $('#messageDisplay').val('');
    $('#itemDisplay').val('');
    $('#changeDisplay').empty();
      });
});

function purchaseItem() {

  $.ajax({
    type: 'GET',
    url: 'http://localhost:8080/money/' + $('#total').val() + '/item/' + $('#itemDisplay').val(),
    success: function(changeArray) {

        var total = document.querySelector('#total');
        total.value = '';
        var row = '';

        if(changeArray.quarters != '0')
        {var quarters = changeArray.quarters;
        row += quarters + ' Quarter(s)';};

        if(changeArray.dimes != '0')
        {var dimes = changeArray.dimes;
        row += dimes + ' Dime(s)';};

        if(changeArray.nickels != '0')
        {var nickels = changeArray.nickels;
        row += nickels + ' Nickel(s)';};

        var chnageDisplay = document.querySelector('#changeDisplay')
        changeDisplay.append(row);

        clearItems();
        var messageDisplay = document.querySelector('#messageDisplay');
        messageDisplay.value = 'Thank you!!!';
        loadItems();

    },
    error: function(response) {
      var displayMessage = response.responseJSON.message;
      $('#messageDisplay').val(displayMessage);
    }
  });
};

function clearItems() {
  $('#itemDiv1').empty();
  $('#itemDiv2').empty();
  $('#itemDiv3').empty();
  $('#itemDiv4').empty();
  $('#itemDiv5').empty();
  $('#itemDiv6').empty();
  $('#itemDiv7').empty();
  $('#itemDiv8').empty();
  $('#itemDiv9').empty();
};

function loadItems() {
  var itemDiv1 = $('#itemDiv1')

  $.ajax({
    type: 'GET',
    url: 'http://localhost:8080/items',
    success: function(itemArray) {

        var itemId = itemArray[0].id;
        var name = itemArray[0].name;
        var price = itemArray[0].price;
        var quantity = itemArray[0].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '0</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv1.append(row);

        var itemValue1 = document.querySelector('#snickers');
        itemValue1.value = itemId;

        var itemDiv2 = $('#itemDiv2')

        var itemId = itemArray[1].id;
        var name = itemArray[1].name;
        var price = itemArray[1].price;
        var quantity = itemArray[1].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv2.append(row);

        var itemValue2 = document.querySelector('#mandms');
        itemValue2.value = itemId;

        var itemDiv3 = $('#itemDiv3')

        var itemId = itemArray[2].id;
        var name = itemArray[2].name;
        var price = itemArray[2].price;
        var quantity = itemArray[2].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv3.append(row);

        var itemValue3 = document.querySelector('#almondJoy');
        itemValue3.value = itemId;

        var itemDiv4 = $('#itemDiv4')

        var itemId = itemArray[3].id;
        var name = itemArray[3].name;
        var price = itemArray[3].price;
        var quantity = itemArray[3].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv4.append(row);

        var itemValue4 = document.querySelector('#milkyWay');
        itemValue4.value = itemId;

        var itemDiv5 = $('#itemDiv5')

        var itemId = itemArray[4].id;
        var name = itemArray[4].name;
        var price = itemArray[4].price;
        var quantity = itemArray[4].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv5.append(row);

        var itemValue5 = document.querySelector('#payDay');
        itemValue5.value = itemId;

        var itemDiv6 = $('#itemDiv6')

        var itemId = itemArray[5].id;
        var name = itemArray[5].name;
        var price = itemArray[5].price;
        var quantity = itemArray[5].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '0</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv6.append(row);

        var itemValue6 = document.querySelector('#reeses');
        itemValue6.value = itemId;

        var itemDiv7 = $('#itemDiv7')

        var itemId = itemArray[6].id;
        var name = itemArray[6].name;
        var price = itemArray[6].price;
        var quantity = itemArray[6].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv7.append(row);

        var itemValue7 = document.querySelector('#pringles');
        itemValue7.value = itemId;

        var itemDiv8 = $('#itemDiv8')

        var itemId = itemArray[7].id;
        var name = itemArray[7].name;
        var price = itemArray[7].price;
        var quantity = itemArray[7].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '.00</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv8.append(row);

        var itemValue8 = document.querySelector('#cheezits');
        itemValue8.value = itemId;

        var itemDiv9 = $('#itemDiv9')

        var itemId = itemArray[8].id;
        var name = itemArray[8].name;
        var price = itemArray[8].price;
        var quantity = itemArray[8].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv9.append(row);

        var itemValue9 = document.querySelector('#doritos');
        itemValue9.value = itemId;

    },
    error: function() {
      alert("Error!");
    }
  });
}
