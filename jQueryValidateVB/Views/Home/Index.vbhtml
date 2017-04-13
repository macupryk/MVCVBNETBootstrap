@Code
    ViewData("Title") = "Home Page"
End Code

<div class="container">
    <div class="row">
        @Html.AntiForgeryToken()
        @Using Html.BeginForm("Index", "Home", FormMethod.Post, New With {.id = "frmInput", .class = "form-horizontal"})
            @<div class="form-group has-feedback">
                <label for="fname" class="control-label col-md-3">First Name:</label>
                <div class="col-md-9">
                    <input type="text" name="fname" id="fname" class="form-control" placeholder="Enter first name" />
                    <span class="glyphicon form-control-feedback" id="fname1"/>
                </div>
            </div>            
            @<div class="form-group has-feedback">
                <label for="mname" class="control-label col-md-3">Middle Name:</label>
                <div class="col-md-9">
                    <input type="text" name="mname" id="mname" class="form-control" placeholder="Enter middle name" />
                    <span class="glyphicon form-control-feedback" id="mname1"></span>
                </div>
            </div>
            @<div class="form-group has-feedback">
                <label for="lname" class="control-label col-md-3">Last Name:</label>
                <div class="col-md-9">
                    <input type="text" name="lname" id="lname" class="form-control" placeholder="Enter last name" />
                    <span class="glyphicon form-control-feedback" id="lname1"></span>
                </div>
            </div>
            @<div class="form-group has-feedback">
                <label for="email" class="control-label col-md-3">Email Address:</label>
                <div class="col-md-9">
                    <input type="email" name="email" id="email" class="form-control" placeholder="Enter email" />
                    <span class="glyphicon form-control-feedback" id="email1"></span>
                </div>
            </div>
            @<div class="form-group has-feedback">
                <label for="password" class="control-label col-md-3">Password:</label>
                <div class="col-md-9">
                    <input type="password" name="password" id="password" class="form-control" placeholder="Enter password" />
                    <span class="glyphicon form-control-feedback" id="password1"></span>
                </div>
            </div>
            @<div class="form-group has-feedback">
                <label for="confirm_password" class="control-label col-md-3">Confirm Password:</label>
                <div class="col-md-9">
                    <input type="password" name="confirm_password" id="confirm_password" class="form-control" placeholder="Confirm password" />
                    <span class="glyphicon form-control-feedback" id="confirm_password1"></span>
                </div>
            </div>
            @<div class="form-group">
                <div class="col-sm-offset-3 col-md-9">
                    <input type="submit" class="btn btn-primary" value="Register">
                    <button type="button" class="btn">Cancel</button>
                </div>
            </div>

        End Using
    </div>
</div>
