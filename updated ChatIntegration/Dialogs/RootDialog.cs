using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Globalization;
namespace ChatIntegration.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }
        static int z = 0;
        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            // calculate something for us to return
            int length = (activity.Text ?? string.Empty).Length;
            bool yes = false;
            if (z == 10)
            {
                string imagefile = activity.Text;
                Process a = new Process();
                a.StartInfo.FileName = @"C:\Users\Vijay\Documents\for cortana skill\ConsoleApplication13\ConsoleApplication13\bin\Debug\ConsoleApplication13";
                a.StartInfo.Arguments = activity.Text;
                a.Start();
                z = 0;
            }
            if (z == 1)
            {
                foreach (char m in activity.Text)
                {
                    if (m == ':')
                    {
                        yes = true;
                        break;
                    }
                }                    
                    if (yes == true)
                    {
                        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                        registry.SetValue("ProxyEnable", 1);
                        registry.SetValue("ProxyServer", activity.Text);
                        z = 0;
                        await context.PostAsync("What else can I do for you?");
                        context.Wait(MessageReceivedAsync);
                }
                    else
                    {
                        await context.PostAsync("Please reenter your proxy in proper format");
                        context.Wait(MessageReceivedAsync); 
                    }
              }
            

            else if (activity.Text.Contains("alarm") || activity.Text.Contains("Alarm"))
            {
                Process.Start(@"C:\Users\Vijay\Documents\alarm\WindowsFormsApplication1\bin\Debug\Alarm.exe");
                await context.PostAsync($"What else can I do for you");
                context.Wait(MessageReceivedAsync);

            }
            else if (activity.Text.Contains("Run") || activity.Text.Contains("run") || activity.Text.Contains("Find") || activity.Text.Contains("find") || activity.Text.Contains("Play") || activity.Text.Contains("play") || activity.Text.Contains("Open") || activity.Text.Contains("open"))
            {
                await context.PostAsync($"Okay");
                Process a = new Process();
                a.StartInfo.FileName = @"C:\Users\Vijay\go\tsearch.py";
                a.StartInfo.Arguments = activity.Text;
                a.Start();
                context.Wait(MessageReceivedAsync);
            }
            else if (activity.Text.Contains("Proxy") || activity.Text.Contains("proxy"))
            {
                await context.PostAsync($"Enter your proxy in format 127.0.0.0:8080");
                z++;
                context.Wait(MessageReceivedAsync);

            }
            else if (activity.Text.Contains("Duplicate") || activity.Text.Contains("duplicate"))
            {
                await context.PostAsync($"Okay");
                Process.Start(@"C:\Users\Vijay\Documents\updated cortana\Cortana\Cortana\bin\Debug\Cortana.exe");
                context.Wait(MessageReceivedAsync);
            }
            else if (activity.Text.Contains("extract text") || (activity.Text.Contains("image") && activity.Text.Contains("text")))
            {
                await context.PostAsync($"Enter file address in console");
                context.Wait(MessageReceivedAsync);
                z = 10;

            }
            else
            {
                await context.PostAsync($"You sent {activity.Text}");
                context.Wait(MessageReceivedAsync);

            }

            // return our reply to the user
            //

            
        }
    }
}