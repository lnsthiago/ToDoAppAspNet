(function () {
    $('.btn-update-name').on('click', function (e) {
        var $modal = $('#updateNameTaskModal');

        $modal.modal('show');
        e.preventDefault();
    });
})();
