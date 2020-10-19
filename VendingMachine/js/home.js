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

function itemButton(value) {
  const item = document.querySelector('#itemDisplay');
  item.value = value;
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

        var i;
        for(i = 0; i < itemArray.length; i++) {

        var itemDivString = "#itemDiv" + (i+1);
        var itemDiv = $(itemDivString);

        var itemString = "#item" + (i+1);
        var itemValue = $(itemString);

        var itemId = itemArray[i].id;
        var name = itemArray[i].name;
        var price = itemArray[i].price;
        var quantity = itemArray[i].quantity;

        var row = '<p>';
            row += '<p class=pull-left>' + itemId + '</p><br/>';
            row += '<p>' + name + '</p><br/>';
            row += '<p>$' + price + '0</p><br/><br/><br/><br/>';
            row += '<p>Quanity Left: ' + quantity + '</p>';
            row += '</p>';

        itemDiv.append(row);

        itemValue.val(itemId);
}

    },
    error: function() {
      alert("Error!");
    }
  });
}
