
#ifndef DEVICESELECTOR_H_INCLUDED
#define DEVICESELECTOR_H_INCLUDED

#include "../JuceLibraryCode/JuceHeader.h"

class DeviceSelector : public Component, public Button::Listener
{
	public:
		DeviceSelector(AsyncSocket* in)
		{
			socket = in;

			std::vector<String> deviceList;
			if (socket != nullptr)
				deviceList = socket->GetDeviceList();

			if (deviceList.size() > 0)
			{
				device1Button = new TextButton();
				device1Button->setButtonText(deviceList[0]);
				device1Button->setBounds(270, 200, 210, 34);
				device1Button->addListener(this);
				addAndMakeVisible(device1Button);
			}
			if (deviceList.size() > 1 && deviceList[1].length())
			{
				device2Button = new TextButton();
				device2Button->setButtonText(deviceList[1]);
				device2Button->setBounds(270, 250, 210, 34);
				device2Button->addListener(this);
				addAndMakeVisible(device2Button);
			}
			if (deviceList.size() > 2 && deviceList[2].length())
			{
				device3Button = new TextButton();
				device3Button->setButtonText(deviceList[2]);
				device3Button->setBounds(270, 300, 210, 34);
				device3Button->addListener(this);
				addAndMakeVisible(device3Button);
			}
			if (deviceList.size() > 3 && deviceList[3].length())
			{
				device4Button = new TextButton();
				device4Button->setButtonText(deviceList[3]);
				device4Button->setBounds(270, 350, 210, 34);
				device4Button->addListener(this);
				addAndMakeVisible(device4Button);
			}
		}

		void paint (Graphics& g) override
		{
			g.setColour (Colours::white);
			g.setFont(64.0f);
			g.drawText("SDK LIVE REPORT", Rectangle<int>(0, 25, 750, 100), Justification::centredTop, true);
			g.setFont(32.0f);
			g.drawText("SELECT YOUR DEVICE", Rectangle<int>(0, 120, 750, 100), Justification::centredTop, true);
		}

		void buttonClicked (Button* button) override
		{
			if (socket != nullptr)
			{
				if (button == device1Button)
					socket->SetDevice("0");
				else if (button == device2Button)
					socket->SetDevice("1");
				else if (button == device3Button)
					socket->SetDevice("2");
				else if (button == device4Button)
					socket->SetDevice("3");
			}
		}

	private:
		AsyncSocket* socket = nullptr;

		String selectedDevice;
		ScopedPointer<TextButton> device1Button;
		ScopedPointer<TextButton> device2Button;
		ScopedPointer<TextButton> device3Button;
		ScopedPointer<TextButton> device4Button;
		JUCE_DECLARE_NON_COPYABLE_WITH_LEAK_DETECTOR (DeviceSelector)
};

#endif  // DEVICESELECTOR_H_INCLUDED
