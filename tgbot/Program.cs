using tgbot.Input;
using tgbot.Logic;

InputTextCLass inputTextCLass = new InputTextCLass();
inputTextCLass.InputText();

string data = string.Empty;
ILogic logic = new LogicTextClass();
void  func (ILogic l) {
    l.LogicText(data);
}