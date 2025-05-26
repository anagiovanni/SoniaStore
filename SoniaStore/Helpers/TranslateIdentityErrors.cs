namespace SoniaStore.Helpers;

public static class TranslateIdentityErrors
{
    public static string TranslateErrorMessage(string codeError)
    {
        string message = codeError switch
        {
            "DefaultError" => "Ocorreu um erro desconhecido.",
            "ConcurrencyFailure" => "Falha de concorrência otimista, o objeto foi modificado.",
            "InvalidToken" => "Token inválido.",
            "LoginAlreadyAssociated" => "Já existe um usuário com este login.",
            "InvalidUserName" => "Este login é inválido, um login deve conter apenas letras ou dígitos.",
            "InvalidEmail" => "Email inválido.",
            "DuplicateUserName" => "Este login já está sendo utilizado.",
            "DuplicateEmail" => "Este email já está sendo utilizado.",
            "InvalidRoleName" => "Este nome de função é inválido.",
            "DuplicateRoleName" => "Esta permissão já está sendo utilizada.",
            "UserAlreadyInRole" => "Usuário já possui esta permissão.",
            "UserNotInRole" => "Usuário não tem esta permissão.",
            "UserLockoutNotEnabled" => "Lockout não está habilitado para este usuário.",
            "UserAlreadyHasPassword" => "Usuário já possui uma senha definida.",
            "PasswordMismatch" => "Senha incorreta.",
            "PasswordTooShort" => "Senha muito curta.",
            "PasswordRequiresNonAlphanumeric" => "Senhas devem conter ao menos um caractere não alfanumérico.",
            "PasswordRequiresDigit" => "Senhas devem conter ao menos um dígito (\"0\"-\"9\").",
            "PasswordRequiresUpper" => "Senhas devem conter ao menos um caractere em caixa alta (\"A\"-\"Z\").",
            "PasswordRequiresLower" => "Senhas devem conter ao menos um caractere em caixa baixa (\"a\"-\"z\").",
            _ => "Ocorreu um erro desconhecido.",
        };
        return message;
    }
}