public class Solution {
    public bool DetectCapitalUse(string word) {

        //Verificar se todas as letras estao maisculas
        if (word.ToUpper() == word)
            return true;
        
        //Vericar se todas as letras sao minusculas
        if (word.ToLower() == word)
            return true;
        
        //Verificar se apenas a primeira letra e maiuscula e o restante esta minusculo
        if (char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1))
            return true;
        
        return false; 
    }
}