System.Text.StringBuilder sb = new System.Text.StringBuilder("Rat is my favorite animal.");

System.Console.WriteLine(@$"Before change : sb = {sb.ToString()}, 
sb.GetHashCode = {sb.GetHashCode()}");

System.Console.WriteLine(@"Replace first char in sb  from R to C");
sb[0] = 'C';

System.Console.WriteLine(@$"After change : sb = {sb.ToString()}, 
sb.GetHashCode = {sb.GetHashCode()}");
