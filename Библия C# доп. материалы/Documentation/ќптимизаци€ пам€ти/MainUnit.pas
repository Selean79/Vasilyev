unit MainUnit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  PMassivItem = ^TMassivItem;
  TMassivItem = record
   nextItem:PMassivItem;
   prevItem:PMassivItem;
   Name:String;
  end;

  TMassiv = class
   public
    FirstItem:PMassivItem;
    LastItem:PMassivItem;
    itemsNumber:Integer;
    constructor Create(str:String);
    procedure AddItem(str:String);
    procedure DeleteItem(index:Integer);
  end;

  TForm1 = class(TForm)
    Button1: TButton;
    ListBox1: TListBox;
    Edit1: TEdit;
    procedure FormCreate(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
    mass:TMassiv;
    procedure ShowItems;
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

{ TMassiv }

procedure TMassiv.AddItem(str:String);
var
 newItem:PMassivItem;
begin
 newItem:= new(PMassivItem);
 newItem.Name:=str;
 newItem.nextItem:=nil;
 newItem.prevItem:=LastItem;

 LastItem.nextItem:=newItem;
 LastItem:=newItem;

 Inc(itemsNumber);
end;

constructor TMassiv.Create(str:String);
begin
 itemsNumber:=1;

 FirstItem:=new(PMassivItem);
 FirstItem.Name:=str;
 FirstItem.nextItem:=nil;
 FirstItem.prevItem:=nil;

 LastItem:=FirstItem;
end;

procedure TMassiv.DeleteItem(index: Integer);
var
 i:Integer;
 currentItem:PMassivItem;
begin
 if index>=itemsNumber then
  begin
   ShowMessage('Индекс удаляемого элемента выходит за границы');
   exit;
  end;

 // поиск удаляемого элемента
 currentItem:=FirstItem;
 for i:=0 to index-1 do
  currentItem:=currentItem.nextItem;

 if currentItem.prevItem<>nil then
  currentItem.prevItem.nextItem:=currentItem.nextItem;

 if currentItem.nextItem<>nil then
  currentItem.nextItem.prevItem:=currentItem.prevItem;

 if FirstItem=currentItem then
  FirstItem:=currentItem.nextItem;

 if LastItem=currentItem then
  LastItem:=currentItem.prevItem;

 Dispose(currentItem);
 Dec(itemsNumber);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
 mass:=TMassiv.Create('1');
 mass.AddItem('2');
 mass.AddItem('3');
 mass.AddItem('4');
 mass.AddItem('5');
 ShowItems;
end;

procedure TForm1.ShowItems;
var
 i:Integer;
 currentItem:PMassivItem;
begin
 ListBox1.Items.Clear;
 currentItem:=mass.FirstItem;
 for i:=0 to mass.itemsNumber-1 do
  begin
   ListBox1.Items.Add(currentItem.Name);
   currentItem:=currentItem.nextItem;
  end;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
 mass.DeleteItem(StrToint(Edit1.Text));
 ShowItems;
end;

end.
