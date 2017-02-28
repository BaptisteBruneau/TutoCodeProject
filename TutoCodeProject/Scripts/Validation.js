function IsFirstNameEmpty()
{
    if (document.getElementById("TxtFirstName").value == "")
        return "Le champ FirstName ne peut pas être vide";
    else
        return "";
}

function IsFirstNameContainSymbol()
{
    if (document.getElementById("TxtFirstName").value.indexOf('@') != -1)
        return "Le champs FirstName ne doit pas comprendre d'@";
    else
        return "";
}

function IsLastNameEmpty()
{
    if (document.getElementById("TxtLastName").value == "")
        return "Le champ LastName ne peut pas être vide";
    else
        return "";
}

function IsLastNameGreatherThanFive() {
    if (document.getElementById("TxtLastName").value.length >= 5)
        return "Le champ LastName ne doit pas être supérieur à 5";
    else
        return "";
}

function IsSalaryEmpty()
{
    if (document.getElementById("TxtSalary").value == "")
        return "Le champ Salary ne peut pas être vide";
    else
        return "";
}

function IsSalaryNumber()
{
    if (isNaN(document.getElementById("TxtSalary").value))
        return "Le champ Salary doit être un nombre entier";
    else
        return "";
}

function IsValid()
{
    var FinalErrorsMessage = "Errors: ";

    var FirstNameEmptyMessage = IsFirstNameEmpty();
    var FirstNameContainSymbolMessage = IsFirstNameContainSymbol();
    var LastNameEmptyMessage = IsLastNameEmpty();
    var LastNameGreatherThanFiveMessage = IsLastNameGreatherThanFive();
    var SalaryEmptyMessage = IsSalaryEmpty();
    var SalaryNumberMessage = IsSalaryNumber();

    if (FirstNameEmptyMessage != "")
        FinalErrorsMessage += "\n" + FirstNameEmptyMessage;
    if (FirstNameContainSymbolMessage != "")
        FinalErrorsMessage += "\n" + FirstNameContainSymbolMessage;
    if (LastNameEmptyMessage != "")
        FinalErrorsMessage += "\n" + LastNameEmptyMessage;
    if (LastNameGreatherThanFiveMessage != "")
        FinalErrorsMessage += "\n" + LastNameGreatherThanFiveMessage;
    if (SalaryEmptyMessage != "")
        FinalErrorsMessage += "\n" + SalaryEmptyMessage;
    if (SalaryNumberMessage != "")
        FinalErrorsMessage += "\n" + SalaryNumberMessage;

    if (FinalErrorsMessage != "Errors: ") {
        alert(FinalErrorsMessage);
        return false;
    }
    else
        return true;
    

}