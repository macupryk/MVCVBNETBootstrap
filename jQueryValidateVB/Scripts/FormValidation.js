//bootstrap styling 3.x 
$(function () {

    $("#frmInput").validate({
        submitHandler: function (form) {
            //submit once validation rules are met
            form.submit();
        },
        rules: {
            fname: {
                minlength: 3,
                maxlength: 15,
                required: true
            },
            mname: {
                minlength: 3,
                maxlength: 15,
                required: true
            },
            lname: {
                minlength: 3,
                maxlength: 15,
                required: true
            },
            password: {
                required: true,
                minlength: 6
            },
            confirm_password: {
                required: true,
                minlength: 6,
                equalTo: "#password"
            },
            email: {
                required: true,
                email: true,
                remote: {
                    url: "/Home/EmailExists",
                    type: "post",
                    data: {
                        email: function () {
                            return $('#email').val();
                        }
                    }
                }
            }
        },
        messages: {
            email: {
                remote: "Email already in use!"
            }
        },
        highlight: function (element) {
            var id_attr = "#" + $(element).attr("id") + "1";
            $(element).closest('.form-group').removeClass('has-success').addClass('has-error');
            $(id_attr).removeClass('glyphicon-ok').addClass('glyphicon-remove');
        },
        unhighlight: function (element) {
            var id_attr = "#" + $(element).attr("id") + "1";
            $(element).closest('.form-group').removeClass('has-error').addClass('has-success');
            $(id_attr).removeClass('glyphicon-remove').addClass('glyphicon-ok');
        },
        errorElement: 'span',
        errorClass: 'help-block',
        errorPlacement: function (error, element) {
            if (element.length) {
                error.insertAfter(element);
            } else {
                error.insertAfter(element);
            }
        }
    });
});
