namespace Huggy.Models.Flows
{
   public class FlowItem
   {
      public FlowItem(string name, string value)
      {
         Name = name;
         Value = value;
      }

      public string Name { get; }
      public string Value { get; }

      public static FlowItem Create(string name, string value) => new FlowItem(name, value);
   }
}
