using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_WEBGL
public class WebGLSendContract : MonoBehaviour
{
    async public void proposal(bool vote)
    {
        // smart contract method to call
        string method = "proposal";
        // abi in json format
        string abi = "[{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"uint256\",\"name\": \"vote\",\"type\": \"uint256\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"string\",\"name\": \"problem\",\"type\": \"string\"}],\"name\": \"sendProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";        
        // address of contract
        string contract = "0x4DE0875D56500DCb528f56Ea126d4cc7dC453f4c";
        // array of arguments for contract
        string args = "[\"1\"]";
        // // value in wei
        // string value = "0";
        // // gas limit OPTIONAL
        // string gasLimit = "";
        // // gas price OPTIONAL
        // string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
		string prop;
		if(vote){
			prop = "1";
		} else {
			prop = "0";
		}
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, prop);
            Debug.Log(response);
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

	async public void sendProblem()
    {
        // smart contract method to call
        string method = "problem";
        // abi in json format
        string abi = "[{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"uint256\",\"name\": \"vote\",\"type\": \"uint256\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"string\",\"name\": \"problem\",\"type\": \"string\"}],\"name\": \"sendProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";        
        // address of contract
        string contract = "0x4DE0875D56500DCb528f56Ea126d4cc7dC453f4c";
        // array of arguments for contract
        string args = "[\"1\"]";
        // // value in wei
        // string value = "0";
        // // gas limit OPTIONAL
        // string gasLimit = "";
        // // gas price OPTIONAL
        // string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        Debug.Log(GameObject.Find("SendContract"));
		Text _problem = GameObject.Find("SendContract").transform.GetChild(3).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
        Debug.Log(_problem.text);
		string problem = _problem.text.ToString();
        Debug.Log(problem);
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, problem);
            Debug.Log(response);
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    async public void showYAY()
    {
        // smart contract method to call
        string method = "showYAY";
        // abi in json format
        string abi = "[{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"uint256\",\"name\": \"vote\",\"type\": \"uint256\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"string\",\"name\": \"problem\",\"type\": \"string\"}],\"name\": \"sendProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";        
        // address of contract
        string contract = "0x4DE0875D56500DCb528f56Ea126d4cc7dC453f4c";
        // array of arguments for contract
        string args = "[\"0\"]";
        // // value in wei
        string value = "0";
        // // gas limit OPTIONAL
        // string gasLimit = "";
        // // gas price OPTIONAL
        // string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, value);
            Debug.Log(response);
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    async public void showNAY()
    {
        // smart contract method to call
        string method = "showNAY";
        // abi in json format
        string abi = "[{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"uint256\",\"name\": \"vote\",\"type\": \"uint256\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"string\",\"name\": \"problem\",\"type\": \"string\"}],\"name\": \"sendProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";        
        // address of contract
        string contract = "0x4DE0875D56500DCb528f56Ea126d4cc7dC453f4c";
        // array of arguments for contract
        string args = "[\"0\"]";
        // // value in wei
        string value = "0";
        // // gas limit OPTIONAL
        // string gasLimit = "";
        // // gas price OPTIONAL
        // string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, value);
            Debug.Log(response);
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }
	async public void showProblem()
    {
        // smart contract method to call
        string method = "showProblem";
        // abi in json format
        string abi = "[{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"uint256\",\"name\": \"vote\",\"type\": \"uint256\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"string\",\"name\": \"problem\",\"type\": \"string\"}],\"name\": \"sendProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{\"inputs\": [],\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",\"name\": \"\",\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";        
        // address of contract
        string contract = "0x4DE0875D56500DCb528f56Ea126d4cc7dC453f4c";
        // array of arguments for contract
        string args = "[\"0\"]";
        // // value in wei
        string value = "0";
        // // gas limit OPTIONAL
        // string gasLimit = "";
        // // gas price OPTIONAL
        // string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try {
            string response = await Web3GL.SendContract(method, abi, contract, args, value);
            Debug.Log(response);
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }
}

#endif