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
        // string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        string abi = "[	{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"	},{	\"inputs\": [{	\"internalType\": \"string\",\"name\": \"problem\",	\"type\": \"string\"}],	\"name\": \"problem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",	\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"bool\",	\"name\": \"vote\",	\"type\": \"bool\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{	\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";
        // address of contract
        string contract = "0xB19B95606EF314086772b6A39bd29a3d0Decb650";
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
        // string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        string abi = "[	{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"	},{	\"inputs\": [{	\"internalType\": \"string\",\"name\": \"problem\",	\"type\": \"string\"}],	\"name\": \"problem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",	\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"bool\",	\"name\": \"vote\",	\"type\": \"bool\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{	\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";
        // address of contract
        string contract = "0xB19B95606EF314086772b6A39bd29a3d0Decb650";
        // array of arguments for contract
        string args = "[\"1\"]";
        // // value in wei
        // string value = "0";
        // // gas limit OPTIONAL
        // string gasLimit = "";
        // // gas price OPTIONAL
        // string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
		Text _problem = GameObject.Find("InputField").transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
		string problem = _problem.ToString();
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
        // string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        string abi = "[	{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"	},{	\"inputs\": [{	\"internalType\": \"string\",\"name\": \"problem\",	\"type\": \"string\"}],	\"name\": \"problem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",	\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"bool\",	\"name\": \"vote\",	\"type\": \"bool\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{	\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";
   
        // address of contract
        string contract = "0xB19B95606EF314086772b6A39bd29a3d0Decb650";
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
        // string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        string abi = "[	{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"	},{	\"inputs\": [{	\"internalType\": \"string\",\"name\": \"problem\",	\"type\": \"string\"}],	\"name\": \"problem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",	\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"bool\",	\"name\": \"vote\",	\"type\": \"bool\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{	\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";
        
        // address of contract
        string contract = "0xB19B95606EF314086772b6A39bd29a3d0Decb650";
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
        // string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        string abi = "[	{\"inputs\": [],\"name\": \"endProblem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"	},{	\"inputs\": [{	\"internalType\": \"string\",\"name\": \"problem\",	\"type\": \"string\"}],	\"name\": \"problem\",\"outputs\": [],\"stateMutability\": \"nonpayable\",	\"type\": \"function\"},{\"inputs\": [{	\"internalType\": \"bool\",	\"name\": \"vote\",	\"type\": \"bool\"}],\"name\": \"proposal\",\"outputs\": [],\"stateMutability\": \"nonpayable\",\"type\": \"function\"},{\"stateMutability\": \"payable\",\"type\": \"fallback\"},{	\"stateMutability\": \"payable\",\"type\": \"receive\"},{\"inputs\": [],\"name\": \"showNAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showProblem\",\"outputs\": [{\"internalType\": \"string\",\"name\": \"\",\"type\": \"string\"}],\"stateMutability\": \"view\",\"type\": \"function\"},{	\"inputs\": [],	\"name\": \"showYAY\",\"outputs\": [{\"internalType\": \"uint256\",	\"name\": \"\",	\"type\": \"uint256\"}],\"stateMutability\": \"view\",\"type\": \"function\"}]";
        
        // address of contract
        string contract = "0xB19B95606EF314086772b6A39bd29a3d0Decb650";
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