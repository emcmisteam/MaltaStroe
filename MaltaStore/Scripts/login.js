var Login = function () {
    
    return {
        //main function to initiate the module
        init: function () {
        	
           $('.login-form').validate({
	            errorElement: 'label', //default input error message container
	            errorClass: 'help-inline', // default input error message class
	            focusInvalid: false, // do not focus the last invalid input
	            rules: {
	                email: {
	                    required: true,
	                    email: true
	                },
	                password: {
	                    required: true,
	                    minlength: 6
	                },
	                remember: {
	                    required: false
	                }
	            },

	            messages: {
	                email: {
	                    required: "請輸入電子郵件帳號",
	                    email: "請輸入正確電子郵件格式 (例如：EX@gmail.com)"
	                },
	                password: {
	                    required: "請輸入密碼(6~10碼)",
	                    minlength:"最少輸入6碼"
	                }
	            },

	            invalidHandler: function (event, validator) { //display error alert on form submit   
	                $('.alert-error', $('.login-form')).show();
	            },

	            highlight: function (element) { // hightlight error inputs
	                $(element)
	                    .closest('.control-group').addClass('error'); // set error class to the control group
	            },

	            success: function (label) {
	                label.closest('.control-group').removeClass('error');
	                label.remove();
	            },

	            errorPlacement: function (error, element) {
	                error.addClass('help-small no-left-padding').insertAfter(element.closest('.input-icon'));
	            },

	            
	            submitHandler: function (form) {
	                window.location.href = "Auth/index";
                    /*
	                var email = $('input[name="email"]').val(),
                         pass = $('input[name="password"]').val();
	                if (email && pass) {
	                    $('.content').hide();
	                    $('#laoding').modal({
	                        backdrop: 'static',
	                        keyboard: true
	                    });
	                    setTimeout(function () {
	                        form.submit();
	                    }, 10000);
	                    //return true;
	                } else {
	                    return false;
	                }
                    */
	            }
	        });

           $('.login-form input').keypress(function (e) {
	            if (e.which == 13) {
	                if ($('.login-form').validate().form()) {
	                    window.location.href = "Auth/index";
	                }
	                return false;
	            }
	        });

	        $('.forget-form').validate({
	            errorElement: 'label', //default input error message container
	            errorClass: 'help-inline', // default input error message class
	            focusInvalid: false, // do not focus the last invalid input
	            ignore: "",
	            rules: {
	                email: {
	                    required: true,
	                    email: true
	                }
	            },

	            messages: {
	                email: {
	                    required: "請輸入電子郵件帳號",
	                    email: "請輸入正確電子郵件格式 (例如：EX@gmail.com)"
	                }
	            },

	            invalidHandler: function (event, validator) { //display error alert on form submit   

	            },

	            highlight: function (element) { // hightlight error inputs
	                $(element)
	                    .closest('.control-group').addClass('error'); // set error class to the control group
	            },

	            success: function (label) {
	                label.closest('.control-group').removeClass('error');
	                label.remove();
	            },

	            errorPlacement: function (error, element) {
	                error.addClass('help-small no-left-padding').insertAfter(element.closest('.input-icon'));
	            },

	            submitHandler: function (form) {
	                window.location.href = "Auth/index";
	            }
	        });

	        $('.forget-form input').keypress(function (e) {
	            if (e.which == 13) {
	                if ($('.forget-form').validate().form()) {
	                    window.location.href = "Auth/index";
	                }
	                return false;
	            }
	        });

	        jQuery('#forget-password').click(function () {
	            jQuery('.login-form').hide();
	            jQuery('.forget-form').show();
	        });

	        jQuery('#back-btn').click(function () {
	            jQuery('.login-form').show();
	            jQuery('.forget-form').hide();
	        });

	        $('.register-form').validate({
	            errorElement: 'label', //default input error message container
	            errorClass: 'help-inline', // default input error message class
	            focusInvalid: false, // do not focus the last invalid input
	            ignore: "",
	            rules: {
	                username: {
	                    required: true
	                },
	                password: {
	                    required: true,
	                    minlength: 6
	                },
	                rpassword: {
	                    equalTo: "#register_password"
	                },
	                email: {
	                    required: true,
	                    email: true
	                }
	            },

	            messages: { // custom messages for radio buttons and checkboxes
	                username: {
	                    required: "請輸入使用者名稱"
	                },
	                password: {
	                    required: "請輸入密碼(6~10碼)",
	                    minlength: "最少輸入6碼"
	                },
	                rpassword: {
	                    equalTo: "密碼不符"
	                },
	                email: {
	                    required: "請輸入電子郵件帳號",
	                    email: "請輸入正確電子郵件格式 (例如：EX@gmail.com)"
	                },

	            },

	            invalidHandler: function (event, validator) { //display error alert on form submit   

	            },

	            highlight: function (element) { // hightlight error inputs
	                $(element)
	                    .closest('.control-group').addClass('error'); // set error class to the control group
	            },

	            success: function (label) {
	                label.closest('.control-group').removeClass('error');
	                label.remove();
	            },

	            errorPlacement: function (error, element) {
	                if (element.attr("name") == "tnc") { // insert checkbox errors after the container                  
	                    error.addClass('help-small no-left-padding').insertAfter($('#register_tnc_error'));
	                } else {
	                    error.addClass('help-small no-left-padding').insertAfter(element.closest('.input-icon'));
	                }
	            },

	            submitHandler: function (form) {
	                window.location.href = "Auth/index";
	            }
	        });

	        jQuery('#register-btn').click(function () {
	            jQuery('.login-form').hide();
	            jQuery('.register-form').show();
	        });

	        jQuery('#register-back-btn').click(function () {
	            jQuery('.login-form').show();
	            jQuery('.register-form').hide();
	        });
        }

    };

}();