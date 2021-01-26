$(document).ready(function() {
  $('#create-button').on('click', function(){
        $('#createFormDiv').show();
        $('#main-menu').hide();
        $('#createFormDiv').reset();
      });

  loadDvds();

  $('#create-cancel-button').on('click', function(){
    $('#createFormDiv').hide();
    $('#main-menu').show();
  });

  $('#edit-cancel-button').on('click', function(){
    $('#editFormDiv').hide();
    $('#main-menu').show();
  });

  $('#view-back-button').on('click', function(){
    $('#viewDvdDiv').hide();
    $('#main-menu').show();
  });

  $('#create-dvd-button').click(function (event) {

      $.ajax({
        type: 'POST',
        url: 'http://localhost:62340/dvd',
        data: JSON.stringify({
          title: $('#create-dvd-title').val(),
          releaseYear: $('#create-release-year').val(),
          director: $('#create-director').val(),
          rating: $('#create-rating').val(),
          notes: $('#create-notes').val()
        }),
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        },
        'dataType': 'json',
        success: function() {
          $('#errorMessages').empty();
          $('#create-title').val('');
          $('#create-release-year').val('');
          $('#create-director').val('');
          $('#create-rating').val('');
          $('#create-notes').val('');
          loadDvds();
          $('#createFormDiv').hide();
          $('#main-menu').show();
        },
        error: function() {
          $('#errorMessages')
            .append($('<li>')
            .attr({class: 'list-group-item list-group-item-danger'})
            .text('Error calling web service. Please try again later.'));
        }
      })

    });

    $('#edit-dvd-button').click(function (event) {

        $.ajax({
          type: 'PUT',
          url: 'http://localhost:62340/dvd/' + $('#edit-dvd-id').val(),
          data: JSON.stringify({
            dvdId: $('#edit-dvd-id').val(),
            title: $('#edit-dvd-title').val(),
            releaseYear: $('#edit-release-year').val(),
            director: $('#edit-director').val(),
            rating: $('#edit-rating').val(),
            notes: $('#edit-notes').val()
          }),
          headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
          },
          'dataType': 'json',
          success: function() {
            $('#errorMessages').empty();
            $('#edit-title').val('');
            $('#edit-release-year').val('');
            $('#edit-director').val('');
            $('#edit-rating').val('');
            $('#edit-notes').val('');
            loadDvds();
            $('#editFormDiv').hide();
            $('#main-menu').show();
          },
          error: function() {
            $('#errorMessages')
              .append($('<li>')
              .attr({class: 'list-group-item list-group-item-danger'})
              .text('Error calling web service. Please try again later.'));
          }
        })

      });

});

function loadDvds() {
  clearContactTable();
  var contentRows = $('#contentRows')

  $.ajax({
    type: 'GET',
    url: 'http://localhost:62340/dvds',
    success: function(dvdArray) {
      $.each(dvdArray, function(index, dvd) {
        var title = dvd.title;
        var releaseYear = dvd.releaseYear;
        var dvdId = dvd.dvdId;
        var director = dvd.director;
        var rating = dvd.rating;
        var notes = dvd.notes;

        var row = '<tr>';
            row += '<td>' + '<a onclick="viewDvd(' + dvdId + ')">' + title + '</a>' + '</td>';
            row += '<td>' + releaseYear + '</td>';
            row += '<td>' + director + '</td>';
            row += '<td>' + rating + '</td>';
            row += '<td>' + '<a onclick="showEditForm(' + dvdId + ')">Edit</a>' + ' | ' + '<a onclick="deleteDvd(' + dvdId + ')">Delete</a>' + '</td>';
            row += '</tr>';

        contentRows.append(row);
      });
    },
    error: function() {
      $('#errorMessages')
        .append($('<li>')
        .attr({class: 'list-group-item list-group-item-danger'})
        .text('Error calling web service. Please try again later.'));
    }
  });
}

function clearContactTable() {
  $('#contentRows').empty();
}

function showEditForm(dvdId) {
  $('#errorMessages').empty();

  $.ajax({
    type: 'GET',
    url: 'http://localhost:62340/dvd/' + dvdId,
    success: function(data, status) {
      $('#edit-dvd-title').val(data.title);
      $('#edit-release-year').val(data.releaseYear);
      $('#edit-director').val(data.director);
      $('#edit-rating').val(data.rating);
      $('#edit-notes').val(data.notes);
      $('#edit-dvd-id').val(data.dvdId);
    },
    error: function(){
      $('#errorMessages')
        .append($('<li>')
        .attr({class: 'list-group-item list-group-item-danger'})
        .text('Error calling web service. Please try again later.'));
    }
  });

  $('#main-menu').hide();

  $('#editFormDiv').show();
}

function hideEditForm() {
  $('#errorMessages').empty();

  $('#editFormDiv').hide();

  $('#main-menu').show();
}

function deleteDvd(dvdId) {
  $.ajax({
    type: 'DELETE',
    url: 'http://localhost:62340/dvd/' + dvdId,
    success: function() {
      loadDvds();
    }
  });
}

function viewDvd(dvdId) {

  $('#view-dvd-title').empty();
  $('#view-release-year').empty();
  $('#view-director').empty();
  $('#view-rating').empty();
  $('#view-notes').empty();

  $.ajax({
    type: 'GET',
    url: 'http://localhost:62340/dvd/' + dvdId,
    success: function(data, status) {

      var title = data.title;
      var releaseYear = data.releaseYear;
      var director = data.director;
      var rating = data.rating;
      var notes = data.notes;

      $('#view-dvd-title').append(title);
      $('#view-release-year').append(releaseYear);
      $('#view-director').append(director);
      $('#view-rating').append(rating);
      $('#view-notes').append(notes);

    },
    error: function(){
      $('#errorMessages')
        .append($('<li>')
        .attr({class: 'list-group-item list-group-item-danger'})
        .text('Error calling web service. Please try again later.'));
    }
  });

  $('#main-menu').hide();
  $('#viewDvdDiv').show();
}
