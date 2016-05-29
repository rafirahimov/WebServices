<?php
class client{

	public function __construct(){
		$this->instance = new SoapClient('http://localhost:55277/Service.svc?wsdl',array("trace" => 1, "exception" => 0));	
	}
	
	public function StartCalculate(){		
		$addRequest = new stdClass();
		$addRequest = array('a' => 45, 'b' => 12, 'operation' => '+');
		 return $this->instance->Calculate($addRequest);
	}
	
}

$client = new client;

echo ($client -> StartCalculate()->CalculateResult);

?>