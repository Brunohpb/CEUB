import java.util.Arrays;
import java.util.List;

class Aula3 {

    public static void main(String[] args){
        
        //Antes do Java 8
        List<String> lista1 = Arrays.asList (
                "Santa Catarina",
                "Parana",
                "São Paulo",
                "Rio de Janeiro",
                "Brasilia",
                "Ceará");
        // for (String s : lista1)
          //  System.out.println(s);
        //lista1.forEach(x -> System.out.println(x));
        lista1.forEach(System.out::println);
    }
}
