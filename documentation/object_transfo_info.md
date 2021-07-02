# Command

    <object_transfo_info id="" />

## Description

Returns a 4x4 transformation matrix from a given object.

***

## Parameters
- **id** _(required)_ — object id to be retrieved

***

## Return format
A XML response with the following format:

- **response** — default wrapper for all API responses.
    - **data** — default wrapper for all secondary data API responses.
    - **object_transfo_info** — container for transformation information.
    - 'total_transfo' - provides a 4x4 matrix for the **total** object transformation from all alignments.
    - 'local_transfo' - provides a 4x4 matrix for the **local** object transformation.
    - 'alignments ids - provides all alignment IDs associated with a **total_transfo** response.
	
***

## Errors
- **406** — Missing parameter "id" in request
 
***

## Sample Responses

### Object Transformation Response *with Local Transform and Multiple Alignments


```xml
<response>
   <success>
      <command_received>object_transfo_info</command_received>
      <data>
         <object_transfo_info>
            <total_transfo>
               <row_0>
                  <val_0>0.566528822887065</val_0>
                  <val_1>-0.824041924199368</val_1>
                  <val_2>0</val_2>
                  <val_3>0.17938372548118</val_3>
               </row_0>
               <row_1>
                  <val_0>-0.824041924199367</val_0>
                  <val_1>-0.566528822887065</val_1>
                  <val_2>0</val_2>
                  <val_3>0.208950656292535</val_3>
               </row_1>
               <row_2>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>-1</val_2>
                  <val_3>0</val_3>
               </row_2>
               <row_3>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>0</val_2>
                  <val_3>1</val_3>
               </row_3>
            </total_transfo>
            <local_transfo>
               <row_0>
                  <val_0>0.566528822887065</val_0>
                  <val_1>-0.824041924199368</val_1>
                  <val_2>0</val_2>
                  <val_3>0.17938372548118</val_3>
               </row_0>
               <row_1>
                  <val_0>-0.824041924199367</val_0>
                  <val_1>-0.566528822887065</val_1>
                  <val_2>0</val_2>
                  <val_3>0.208950656292535</val_3>
               </row_1>
               <row_2>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>-1</val_2>
                  <val_3>0</val_3>
               </row_2>
               <row_3>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>0</val_2>
                  <val_3>1</val_3>
               </row_3>
            </local_transfo>
            <alignments ids="0, 4, 2" />
         </object_transfo_info>
      </data>
      <completed />
      <request_id>2</request_id>
   </success>
</response>
```

*The following table demonstrates the above response format.*

<table>
   <tr>
    <th></th>
    <th>val_0</th>
    <th>val_1</th>
    <th>val_2</th>
    <th>val_3</th>
  </tr>
  <tr>
    <th>row_0</th>
    <td>0.566528822887065</td>
    <td>0.824041924199368</td>
    <td>0</td>
    <td>0.17938372548118</td>
  </tr>
  <tr>
    <th>row_1</th>
    <td>-0.824041924199367</td>
    <td>-0.566528822887065</td>
    <td>0</td>
    <td>0.208950656292535</td>
  </tr>
  <tr>
    <th>row_2</th>
    <td>0</td>
    <td>0</td>
    <td>-1</td>
    <td>0</td>
  <tr>
    <th>row_3</th>
    <td>0</td>
    <td>0</td>
    <td>0</td>
    <td>1</td>
  </tr>
</table>
 
### Object Transformation Response with *no* Local Transform and One Alignment
```xml
<response>
   <success>
      <command_received>object_transfo_info</command_received>
      <data>
         <object_transfo_info>
            <total_transfo>
               <row_0>
                  <val_0>0.566528822887065</val_0>
                  <val_1>-0.824041924199368</val_1>
                  <val_2>0</val_2>
                  <val_3>1.37626629899558</val_3>
               </row_0>
               <row_1>
                  <val_0>-0.824041924199367</val_0>
                  <val_1>-0.566528822887065</val_1>
                  <val_2>0</val_2>
                  <val_3>0.121075755780576</val_3>
               </row_1>
               <row_2>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>-1</val_2>
                  <val_3>0</val_3>
               </row_2>
               <row_3>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>0</val_2>
                  <val_3>1</val_3>
               </row_3>
            </total_transfo>
            <alignments ids="4" />
         </object_transfo_info>
      </data>
      <completed />
      <request_id>1</request_id>
   </success>
</response>
```

*The following table demonstrates the above response format.*

<table>
   <tr>
    <th></th>
    <th>val_0</th>
    <th>val_1</th>
    <th>val_2</th>
    <th>val_3</th>
  </tr>
  <tr>
    <th>row_0</th>
    <td>0.566528822887065</td>
    <td>0.824041924199368</td>
    <td>0</td>
    <td>1.37626629899558</td>
  </tr>
  <tr>
    <th>row_1</th>
    <td>-0.824041924199367</td>
    <td>-0.566528822887065</td>
    <td>0</td>
    <td>0.121075755780576</td>
  </tr>
  <tr>
    <th>row_2</th>
    <td>0</td>
    <td>0</td>
    <td>-1</td>
    <td>0</td>
  <tr>
    <th>row_3</th>
    <td>0</td>
    <td>0</td>
    <td>0</td>
    <td>1</td>
  </tr>
</table>

### Object Transformation Response with *only* a Local Transform
```xml
<response>
   <success>
      <command_received>object_transfo_info</command_received>
      <data>
         <object_transfo_info>
            <local_transfo>
               <row_0>
                  <val_0>1</val_0>
                  <val_1>0</val_1>
                  <val_2>0</val_2>
                  <val_3>-0.750481077613855</val_3>
               </row_0>
               <row_1>
                  <val_0>0</val_0>
                  <val_1>1</val_1>
                  <val_2>0</val_2>
                  <val_3>0.936497754971135</val_3>
               </row_1>
               <row_2>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>1</val_2>
                  <val_3>0</val_3>
               </row_2>
               <row_3>
                  <val_0>0</val_0>
                  <val_1>0</val_1>
                  <val_2>0</val_2>
                  <val_3>1</val_3>
               </row_3>
            </local_transfo>
         </object_transfo_info>
      </data>
      <completed />
      <request_id>0</request_id>
   </success>
</response>
```

*The following table demonstrates the above response format.*

<table>
   <tr>
    <th></th>
    <th>val_0</th>
    <th>val_1</th>
    <th>val_2</th>
    <th>val_3</th>
  </tr>
  <tr>
    <th>row_0</th>
    <td>1</td>
    <td>0</td>
    <td>0</td>
    <td>-0.750481077613855</td>
  </tr>
  <tr>
    <th>row_0</th>
    <td>0</td>
    <td>1</td>
    <td>0</td>
    <td>0.936497754971135</td>
  </tr>
  <tr>
    <th>row_0</th>
    <td>0</td>
    <td>1</td>
    <td>0</td>
    <td>0</td>
  </tr>
  <tr>
    <th>row_0</th>
    <td>0</td>
    <td>0</td>
    <td>0</td>
    <td>1</td>
  </tr>
</table>
