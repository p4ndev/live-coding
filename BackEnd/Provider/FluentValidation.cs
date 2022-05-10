using System.Net.Mail;

namespace BackEnd.Provider;

public static class FluentValidation{

    public static bool IsEmail(string term){
        try{
            MailAddress address = new(term);
            return true;
        }catch (FormatException) {
            return false;
        }
    }

}
