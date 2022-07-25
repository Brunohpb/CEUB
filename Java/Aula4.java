import java.util.Arrays;
import java.util.List;
 
// Classe `Person` com campos privados `name` e `age`
class Person
{
    private String name;
    private Integer age;
 
    public Person(String name, Integer age)
    {
        this.name = name;
        this.age = age;
    }
 
    public Integer getAge() {
        return age;
    }
 
    // outros getters e setters
 
    @Override
    public String toString() {
        return "[" + name + ", " + String.valueOf(age) + "]";
    }
 
    public static Person max(Person x, Person y) {
        return x.getAge() > y.getAge() ? x : y;
    }
}
 
// Programa para encontrar o valor máximo de um campo entre objetos personalizados
// usando o método `Stream.reduce()`
class Main
{
    public static void main(String[] args)
    {
        Person p1 = new Person("Jorge", 15);
        Person p2 = new Person("Bruno", 22);
        Person p3 = new Person("Yasmin", 21);
 
        List<Person> users = Arrays.asList(p1, p2, p3);
 
        // pega uma pessoa com a idade máxima
        Person user = users.stream()
                        .reduce(Person::max)
                        .get();
 
        System.out.println("Person with maximum age is " + user);
    }
}