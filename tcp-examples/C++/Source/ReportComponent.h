
#ifndef REPORTCOMPONENT_H_INCLUDED
#define REPORTCOMPONENT_H_INCLUDED

#include "../JuceLibraryCode/JuceHeader.h"
#include <sstream>
#include <iomanip>

class ReportComponent : public Component, public Timer
{
	public:
		ReportComponent (AsyncSocket* in)
		{
			socket = in;
			startTimer (500);
		}

		static String formatNumber (String in)
		{
			std::stringstream ss;
			ss << std::fixed << std::showpoint << std::setprecision (4) << in.getFloatValue();
			return ss.str();
		}

		void paint (Graphics& g) override
		{
			std::vector<String> data;

			if (socket != nullptr)
				data = socket->GetDeviceData();

			g.setColour (Colours::white);

			g.setFont (64.0f);
			g.drawText ("SDK LIVE REPORT", Rectangle<int> (0, 25, 750, 100), Justification::centredTop, true);
			g.setFont (32.0f);
			g.drawText ("BUILD TO CAD TO SEE REAL TIME DATA", Rectangle<int> (0, 120, 750, 100), Justification::centredTop, true);
			g.setFont (40.0f);

			int height = 180;
			int padding = 40;
			int spacing = 167;
			//g.drawText("", Rectangle<int>(padding, height, spacing, 300), Justification::right, false);
			g.drawText ("Nominal", Rectangle<int> (padding + spacing, height, spacing, 100), Justification::topRight, false);
			g.drawText ("Measured", Rectangle<int> (padding + spacing * 2, height, spacing, 100), Justification::topRight, false);
			g.drawText ("Deviation", Rectangle<int> (padding + spacing * 3, height, spacing, 100), Justification::topRight, false);
			//
			height += 50;
			g.drawRect (Rectangle<int> (20, height, 40 + spacing * 4, 1));
			//
			height += 10;
			g.drawText ("X", Rectangle<int> (padding, height, spacing, 300), Justification::topLeft, false);
			g.drawText (formatNumber (data[0]), Rectangle<int> (padding + spacing, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[1]), Rectangle<int> (padding + spacing * 2, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[2]), Rectangle<int> (padding + spacing * 3, height, spacing, 100), Justification::topRight, false);
			//
			height += 50;
			g.drawRect (Rectangle<int> (20, height, 40 + spacing * 4, 1));
			//
			height += 10;
			g.drawText ("Y", Rectangle<int> (padding, height, spacing, 300), Justification::topLeft, false);
			g.drawText (formatNumber (data[3]), Rectangle<int> (padding + spacing, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[4]), Rectangle<int> (padding + spacing * 2, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[5]), Rectangle<int> (padding + spacing * 3, height, spacing, 100), Justification::topRight, false);
			//
			height += 50;
			g.drawRect (Rectangle<int> (20, height, 40 + spacing * 4, 1));
			//
			height += 10;
			g.drawText ("Z", Rectangle<int> (padding, height, spacing, 300), Justification::topLeft, false);
			g.drawText (formatNumber (data[6]), Rectangle<int> (padding + spacing, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[7]), Rectangle<int> (padding + spacing * 2, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[8]), Rectangle<int> (padding + spacing * 3, height, spacing, 100), Justification::topRight, false);
			//
			height += 50;
			g.drawRect (Rectangle<int> (20, height, 40 + spacing * 4, 1));
			//
			height += 10;
			g.drawText ("3D", Rectangle<int> (padding, height, spacing, 300), Justification::topLeft, false);
			//g.drawText (formatNumber (data[]), Rectangle<int> (padding + spacing, height, spacing, 100), Justification::topRight, false);
			g.drawText (formatNumber (data[9]), Rectangle<int> (padding + spacing * 2, height, spacing, 100), Justification::topRight, false);
			//g.drawText (formatNumber (data[]), Rectangle<int> (padding + spacing * 3, height, spacing, 100), Justification::topRight, false);
		}

	private:
		void timerCallback() override
		{
			repaint();
		}

		AsyncSocket* socket = nullptr;
		JUCE_DECLARE_NON_COPYABLE_WITH_LEAK_DETECTOR (ReportComponent)
};

#endif  // REPORTCOMPONENT_H_INCLUDED
