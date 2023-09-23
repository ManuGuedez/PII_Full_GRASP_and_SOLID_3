namespace Full_GRASP_And_SOLID.Library
{
    // Por el patrón Polymorphism, para evitar que la clase AllInOnePrinter pregunte por el destino de la impresión
    // se crea el tipo IPrinter que posee la operación PrintRecipe que va a ser implementado por las clases
    // FilePrinter y ConsolePrinter; con esto creamos un método polimórfico. Ahora existe la posibilidad de crear una 
    // variable del tipo IPrinter en la que podemos ejecutar el método PrintRecipe sin tener que preguntar por el destino.
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}