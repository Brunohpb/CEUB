class Aula2 {

    interface Num{
        double getValue();
    }

    interface ValorNumeric{
        boolean teste(int n);
    }

    interface ValorNumeric2{
        boolean teste(int n , int n2);
    }
    public static void main (String[] args){
       Num n;
       n = () -> 555.11;

       System.out.println(n.getValue());

       Num n2 = () -> Math.random() * 100;
       System.out.println(n2.getValue());
       System.out.println(n2.getValue());

       ValorNumeric isPar = (int i) -> (i % 2) == 0;
       System.out.println(isPar.teste(89));
       System.out.println(isPar.teste(90));

       ValorNumeric2 isDiv = (x , y) -> (x%y)==0;
       System.out.println(isDiv.teste(10 , 2));
       System.out.println(isDiv.teste(10 , 3));
    }
}
