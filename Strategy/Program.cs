using Strategy.EmployeeComparable;
using Strategy.Reports.Common;
using Strategy.Reports.Email;
using Strategy.Reports.Reporter;
using System.Text;

#region EmployeeComparable
var list = new List<Employee>();

list.Add(new Employee { Id = 1, Name = "Mike"});
list.Add(new Employee { Id = 2, Name = "Bob" });
list.Add(new Employee { Id = 3, Name = "Kate" });
list.Add(new Employee { Id = 4, Name = "Bill" }); 
list.Add(new Employee { Id = 5, Name = "Adam" });


var ss = new SortedSet<Employee>(list, ComparerFactory.Create<Employee>((x, y) => x.Name.CompareTo(y.Name)));

foreach (var item in ss)
{
    Console.WriteLine(item);
}
#endregion

#region Report
var receiver = new DataReceiver();

var testMessage = Encoding.UTF8.GetBytes("Тест отчета. Тело отчета.");
var message = receiver.ReceiveData(testMessage);

var dataHandler = new DataHandler();
var emailReportData = dataHandler.Handle<EmailReportData>(message);
var textReportData = dataHandler.Handle<TextReportData>(message);

var reporter = new ReporterService();
reporter.Report(emailReportData);
reporter.Report(textReportData);
#endregion
