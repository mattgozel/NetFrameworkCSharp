$(document).ready(function() {

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
});
