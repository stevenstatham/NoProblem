using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_encoder
{
	class Program
	{
		static void Main(string[] args)
		{
			string projectName;
			int good = 0;
			string activityName;
			string x = "y";
			while (x == "y")
			{
				Console.WriteLine("Enter the Project Name: ");
				projectName = Console.ReadLine();
				good = 0;
				while (good == 0)
				{
					foreach (char i in projectName)
					{
						if (i <= (char)1F & i >= (char)00)
						{
							Console.WriteLine("Input Invalid! Enter a new Project Name without control characters: ");
							projectName = Console.ReadLine();
							break;
						}
						else
						{
							if (i == (char)7F)
							{
								Console.WriteLine("Input Invalid! Enter a new Project Name without control characters: ");
								projectName = Console.ReadLine();
								break;
							}
							else
							{
								good++;
							}
						}
					}
				}
				Console.WriteLine("Enter the Activity Name: ");
				activityName = Console.ReadLine();
				good = 0;
				while (good == 0)
				{
					foreach (char j in activityName)
					{
						if (j <= (char)1F & j >= (char)00)
						{
							Console.WriteLine("Input Invalid! Enter a new Activity Name without control characters: ");
							activityName = Console.ReadLine();
							break;
						}
						else
						{
							if (j == (char)7F)
							{
								Console.WriteLine("Input Invalid! Enter a new Activity Name without control characters: ");
								activityName = Console.ReadLine();
								break;
							}
							else
							{
								good++;
							}
						}
					}
				}
				projectName = projectName.Replace("%", "%25");
				projectName = projectName.Replace(" ", "%20");
				projectName = projectName.Replace("<", "%3C");
				projectName = projectName.Replace(">", "%3E");
				projectName = projectName.Replace("#", "%23");
				projectName = projectName.Replace("\"", "%22");
				projectName = projectName.Replace(";", "%3B");
				projectName = projectName.Replace("/", "%2F");
				projectName = projectName.Replace("?", "%3F");
				projectName = projectName.Replace(":", "%3A");
				projectName = projectName.Replace("@", "%40");
				projectName = projectName.Replace("&", "%26");
				projectName = projectName.Replace("=", "%3D");
				projectName = projectName.Replace("+", "%2B");
				projectName = projectName.Replace("$", "%24");
				projectName = projectName.Replace("{", "%7B");
				projectName = projectName.Replace("}", "%7D");
				projectName = projectName.Replace("|", "%7C");
				projectName = projectName.Replace("\\", "%5C");
				projectName = projectName.Replace("^", "%5E");
				projectName = projectName.Replace("[", "%5B");
				projectName = projectName.Replace("]", "%5D");
				projectName = projectName.Replace("`", "%60");
				activityName = activityName.Replace("%", "%25");
				activityName = activityName.Replace(" ", "%20");
				activityName = activityName.Replace("<", "%3C");
				activityName = activityName.Replace(">", "%3E");
				activityName = activityName.Replace("#", "%23");
				activityName = activityName.Replace("\"", "%22");
				activityName = activityName.Replace(";", "%3B");
				activityName = activityName.Replace("/", "%2F");
				activityName = activityName.Replace("?", "%3F");
				activityName = activityName.Replace(":", "%3A");
				activityName = activityName.Replace("@", "%40");
				activityName = activityName.Replace("&", "%26");
				activityName = activityName.Replace("=", "%3D");
				activityName = activityName.Replace("+", "%2B");
				activityName = activityName.Replace("$", "%24");
				activityName = activityName.Replace("{", "%7B");
				activityName = activityName.Replace("}", "%7D");
				activityName = activityName.Replace("|", "%7C");
				activityName = activityName.Replace("\\", "%5C");
				activityName = activityName.Replace("^", "%5E");
				activityName = activityName.Replace("[", "%5B");
				activityName = activityName.Replace("]", "%5D");
				activityName = activityName.Replace("`", "%60");
				Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectName, activityName);
				Console.WriteLine("Enter 'y' if you would like to continue with another URL.)");
				x = Console.ReadLine();
			}
		}
	}
}
