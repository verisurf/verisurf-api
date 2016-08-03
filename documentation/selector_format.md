# Selector Format

Selector format is a special notation used to select elements in the Verisurf settings.  To determine the format for a selector string you will need to open your VerisurfSettings_(Inch|Metric).xml file and determine the key you would like to change programmatically.

## Example

Writing selector format is as simple as following the XML traversal and including a colon between each element until you arrive at your selected element.

Assuming your settings file has a format similiar to the below:
```xml
<?xml version="1.0" encoding="utf-8"?>
<Verisurf_Inch_Settings>
	<VerisurfX7>
		<TwoVScene>
			<MeasureSettings_CommonDisplay>
				<!-- ... -->
				<SaveAsCloud int="0"/>
				<bRandomClr int="0"/>
				<lastClr int="16711935"/>
				<!-- ... -->
			</MeasureSettings_CommonDisplay>
		</TwoVScene>
	</VerisurfX7>	
</Verisurf_Inch_Settings>
```

and you would like to select the **bRandomClr** setting the format would be:

```
VerisurfX7:TwoVScene:MeasureSettings_CommonDisplay:bRandomClr
```

All selector formats can exclude the root element of their respective settings file in this case "Verisurf_Inch_Settings"
