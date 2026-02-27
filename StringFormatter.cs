using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string delimiter)
		{
			StringBuilder qry = new StringBuilder();

			if(items != null)
			{
				for(int i = 0; i < items.Length; i++)
				{
					string line;
					if (i == items.Length - 1)
					{
						line = string.Format("{0}", items[i]);
					} else
					{
						line = string.Format("{0}{1}", items[i], delimiter);
					}
					qry.Append(line);
				}
			}
			return qry.ToString();
		}
    }
}
