<h2 align="center"> π Unity Library π </h2><br>

ν΄λΉ λ¦¬ν¬μ§ν λ¦¬λ μ λν°λ‘ κ°λ°νλ©΄μ νμνλ κΈ°λ₯μ μ κ° μ§μ  λͺ¨μλκ±°λ μ μν΄μ λ§λ  λΌμ΄λΈλ¬λ¦¬μλλ€. <br>
This repository is a library where Jack Hwang collects or creates features implemented for Unity development.

<h2 align="center"> π³ Getting Started π³ </h2><br>

μ΄ λ¦¬ν¬μ§ν λ¦¬μλ Unityμμ μ κ³΅νμ§ μλ κΈ°λ₯κ³Ό μ€ν¬λ¦½νΈ λ° μ°μ΄λμ κ°μ Unityμ© μ νΈλ¦¬ν°κ° ν¬ν¨λμ΄ μμ΅λλ€.<br>
This repository contains features not provided by Unity and utilities for Unity such as scripts and shaders.
<br><br>
μλμ Git λͺλ Ήμ μ¬μ©νμ¬ Unity νλ‘μ νΈμμ μ§μ  μ¬μ©ν  μ μμ΅λλ€. <br>
You can use it in your Unity project using the Git command below.

<br>

```
git clone https://github.com/DevHwangIT/MyLibrary.git | git submodule add https://github.com/DevHwangIT/MyLibrary.git
```
<br>

λ΄λΆμμ μ¬μ©λλ μ½λλ μλμ κ°μ κ²½λ‘μ λ°λ₯Έ λ€μμ€νμ΄μ€λ‘ κ΅¬λΆλμ΄ μμ΄ κΈ°μ‘΄ μ½λμμ μΆ©λμ λ°©μ§νμμ΅λλ€.<br>
Codes used inside are divided into namespaces according to the following paths to prevent conflicts with existing codes.

<br>

```C#
using namnspace MyLibrary/...
```
<br>

<h2 align="center"> β  Warning β  </h2><br>
Assets / MyLibrary / GameTemplate μ κ²½μ° Unity κ°λ°μ μμ£Όμ¬μ©λλ Manager ν΄λμ€λ₯Ό Partial λ° μ±κΈν€μ λ°νμΌλ‘ κ΅¬νν΄λμ ν΄λμλλ€.<br> ( λ§μΌ, ν΄λΉ κΈ°λ₯μ΄ κΈ°μ‘΄ μ½λμ μΆ©λνκ±°λ νμμλ€λ©΄ ν΄λΉ κ²½λ‘λ§ μ­μ  ν μ¬μ©νμκΈ° λ°λλλ€. )<br><br>

In the case of Assets / MyLibrary / GameTemplate, it is a folder that implements the Manager class, which is often used for Unity development, based on a singleton.<br> ( If the function conflicts with the existing code or is unnecessary, please use it after deleting the corresponding path.)

<br>

<h2 align="center"> π  Update History π  </h2>
<details>
<summary><h3> μλ°μ΄νΈ λ΄μ­ ( History Detail )</h3></summary>
<div markdown="1">
  
2022.06.20 Write ReadMe documents <br>
2022.07.20 Add scriptable singleton function <br>
 
</div>
</details>

<h2 align="center"> π Content π</h2>

<details>
<summary><h3> κ΅¬μ± λ΄μ© ( Contents Detail ) </h3></summary>
<div markdown="1">
<h4> [Path] Assets / MyLibrary / 1.DesignPattern </h4>
- μ λν°μμ μ¬μ©ν  μ μλ λμμΈ ν¨ν΄ κ΄λ ¨ κΈ°λ₯μ λͺ¨μλ λλ ν λ¦¬μλλ€.<br>
  ( A directory contains features related to design patterns available in Unity. )

<h4> [Path] Assets / MyLibrary / 2.Mathematic </h4>  
- μ λν°μμ μ¬μ©ν  μ μλ μν μ°μ°κ³Ό κ΄λ ¨λ κΈ°λ₯μ΄ ν¬ν¨λ λλ ν λ¦¬μλλ€.<br>
  ( A directory containing functions related to mathematical operations available in Unity. )
  
<h4> [Path] Assets / MyLibrary / 3.Tools </h4>
- μ λν°μμ μ¬μ©ν  μ μλ κ²μ κ°λ°μ μν νΈλ¦¬ν κΈ°λ₯κ³Ό λκ΅¬κ° μλ λλ ν λ¦¬μλλ€.<br>
  ( A directory with convenient features and tools for game development available in Unity. )

<h4> [Path] Assets / MyLibrary / 4.Utility </h4>
- μ λν°μμ μμ£Ό μ¬μ©λμ§λ§, κ΅¬νλμ§ μμ κ²μ κ°λ°μ μν ν¨μλ€μ΄ κ΅¬νλμ΄ μλ λλ ν λ¦¬μλλ€.<br>
  ( A directory where features for game development that are frequently used but not implemented in Unity are implemented. )

<h4> [Path] Assets / MyLibrary / 5.Mobile </h4>
- μ λν°μμ λͺ¨λ°μΌ λΉλμμ μ¬μ©ν  μ μλ κΈ°λ₯λ€μ΄ λͺ¨μ¬μλ λλ ν λ¦¬μλλ€.<br>
  ( A directory is a collection of features that can be used when building mobile in Unity. )

<h4> [Path] Assets / MyLibrary / 6.Network </h4>
- μ λν°μμ μ¬μ©ν  μ μλ λ€νΈμν¬ λ° ν΅μ μ μν κΈ°λ₯μ΄ κ΅¬νλμ΄ μλ λλ ν λ¦¬μλλ€.<br>
  ( A directory that implements functions for networking and communication that can be used in Unity. )

<h4> [Path] Assets / MyLibrary / 7.Shader </h4>
- μ λν°μμ μ¬μ©ν  μ μλ μμ΄λ κΈ°λ₯μ μν λλ ν λ¦¬μλλ€.<br>
  ( A Directory for shader features available in Unity. )

<h4> [Path] Assets / MyLibrary / 8.Attribute </h4>
- μ λν° μλν°μμ μ¬μ©ν  μ μλ μ νΈλ¦¬λ·°νΈ κΈ°λ₯μ κ΅¬νν΄ λμ λλ ν λ¦¬μλλ€.<br>
  (A directory that implements attribute functions that can be used in the Unity editor. )

<h4> [Path] Assets / MyLibrary / 99.Etc </h4>
- μ λν°μμ μ¬μ©ν  μ μμ§λ§ λΆλ₯κ° λͺννμ§ μμ μ΄λ₯Ό κ΅¬λΆνκΈ° μν λλ ν λ¦¬μλλ€.<br>
  ( It is available in Unity, but the classification is not clear, so it is a directory to distinguish them. )

<h4> [Path] Assets / MyLibrary / GameTemplate </h4>
- Unityμμ μμ£Ό μ¬μ©λλ Manager κ΄λ ¨ ν΄λμ€ λ° κΈ°λ₯μ΄ κ΅¬νλμ΄ μλ λλ ν λ¦¬μλλ€. <br>
  
[GameTemplateμ κ΄ν μ€μν λ΄μ©μ κ²½κ³ λ₯Ό μ°Έμ‘°νμΈμ.](https://github.com/DevHwangIT/MyLibrary#--warning--) <br> 
  
  ( This is the directory where Manager-related classes and functions frequently used in Unity are implemented. )   
[See the warnings for important information about GameTemplates.](https://github.com/DevHwangIT/MyLibrary#--warning--)
  
</div>
</details>

<h2 align="center"> π§ Contact π§ </h2>

λ§μΌ, ν΄λΉ λΌμ΄λΈλ¬λ¦¬ μ¬μ©μ μμ΄μ λ¬Έμ κ° μκ±°λ κ°μ ν  λΆλΆμ΄ μλ€λ©΄ μλλ₯Ό ν΅ν΄μ μ°λ½ν΄μ£ΌμΈμ. ππ<br>
(If you have problems using the library, Please contact us through below. ππ)

π¬ Email : zxc1063@naver.com or dlsxo1063@cau.ac.kr

