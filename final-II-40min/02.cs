using System;
using System.Linq;
using System.Collections.Generic;

public class Person
{
	public string Header { get; set; }
	public string Source { get; set; }
}

public class Program
{
	public static void Main()
	{

		/*					 ALL TESTS WERE COVERED				*/

		//var res = Check("Beth,Charles,Danielle,Adam,Eric\n17945,10091,10088,3907,10132\n2,12,13,48,11");
		//var equ = "Adam,Beth,Charles,Danielle,Eric\t3907,17945,10091,10088,10132\t48,2,12,13,11";
		
		//var res = Check("Beth,Charles,Danielle,Adam,Eric\n17945,10091,10088,3907,10132");
		//var equ = "Adam,Beth,Charles,Danielle,Eric\t3907,17945,10091,10088,10132";
		
		var res = Check("Beth\n17945");
		var equ = "Beth\t17945";
		
		Console.WriteLine(res);
		Console.WriteLine(equ);
	}

	public static string Check(string csvData)
	{
		int idxRow = 0, idxCell = 0;
		var lst = new List<Person>();
		int times = csvData.Split('\n').Count(), curre = 0;
		string acc = "";
		foreach (var row in csvData.Split('\n'))
		{
			foreach (var cell in row.Split(','))
			{
				switch (idxRow)
				{
					case 0:
						lst.Add(new Person()
						{Header = cell});
						break;
					default:
						lst[idxCell].Source += cell + ",";
						break;
				}

				idxCell++;
			}

			idxRow++;
			idxCell = 0;
		}

		while (curre < times)
		{
			foreach (var item in lst.OrderBy(c => c.Header))
			{
				if (curre == 0)
					acc += item.Header + ",";
				else
					acc += item.Source.Split(',')[curre - 1] + ",";
			}

			acc = acc.Substring(0, acc.Length - 1);
			curre++;
			if (curre < times)
				acc += "\t";
		}

		return acc;
	}
}