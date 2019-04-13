var TableData = new Array();
debugger;
$('#gotTable tr').each(function(row, tr){
  TableData[row]={
    "Character" : $(tr).find('td:eq(5)').text()
    }
    
    var Alys = TableData[0];
    var Arya = TableData[1];
  });
  TableData.shift();
