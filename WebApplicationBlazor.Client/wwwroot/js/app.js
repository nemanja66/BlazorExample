window.toDoInterop = {
    confirmDelete: function (title) {
        $('#toDoTitleField').text(title);
        $('#myModal').modal('show');

        return true;
    },

    hideDeleteDialog: function () {
        $('#myModal').modal('hide');

        return true;
    },
}