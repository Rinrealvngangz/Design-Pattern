
namespace TemplateMethod.Abtracts;

public abstract class CafeinBerage
{
   public  void Prepare()
    {
        BoilWater();
        Brew();
        BoilInUp();
        if (IsCondiment())
        {
            AddCondiment(); 
        }
        
    }

   private void BoilWater()
   {
       
       Console.WriteLine("Nau nuoc");
   }

   private void BoilInUp()
   {
       Console.WriteLine("Pha nuoc");
   }

   protected abstract void Brew();
   protected abstract void AddCondiment();

   protected virtual bool IsCondiment() //hook
   {
       return true;
   }
}