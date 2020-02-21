(function () {
    $('.btn-update-name').on('click', function (e) {
        var $modal = $('#updateNameTaskModal');

        var taskId = $(this).attr('task-id')
        var taskTitle = $(this).attr('task-title');
        var taskDescription = $(this).attr('task-description');

        $modal.modal('show');
        $modal.find('#taskId').val(taskId);
        $modal.find('#taskTitle').val(taskTitle);
        $modal.find('#taskDescription').val(taskDescription);

        e.preventDefault();
    });
})();
