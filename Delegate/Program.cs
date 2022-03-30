using System;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
             try
            {
                
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(MedicineAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
