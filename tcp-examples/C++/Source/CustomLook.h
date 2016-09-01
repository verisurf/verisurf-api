
#ifndef CUSTOMLOOK_H_INCLUDED
#define CUSTOMLOOK_H_INCLUDED

#include "../JuceLibraryCode/JuceHeader.h"

namespace Colors
{
const Colour verisurf_primary (0xff4765A0);
const Colour verisurf_secondary (0xff365490);
const Colour application_background (0xfff3f3f4);
}

class CustomLook : public LookAndFeel_V3
{
	public:
		CustomLook()
		{
			setColour (TextButton::buttonColourId, Colors::verisurf_primary);
			setColour (TextButton::buttonOnColourId, Colors::verisurf_secondary);
			setColour (TextButton::textColourOffId, Colours::white);
			setColour (TextButton::textColourOnId, Colours::white);
			setColour (AlertWindow::backgroundColourId, Colors::application_background);
			robotoTypeFace = Typeface::createSystemTypefaceFor (BinaryData::RobotoSlabRegular_ttf, BinaryData::RobotoSlabRegular_ttfSize);
		}

		//custom buttons to make them flat and bootstrappy
		void drawButtonBackground (Graphics& g, Button& button, const Colour& backgroundColour, bool isMouseOverButton, bool isButtonDown)
		{
			Colour baseColour (backgroundColour);

			if (isButtonDown || isMouseOverButton)
				baseColour = baseColour.contrasting (isButtonDown ? 0.2f : 0.1f);

			const bool flatOnLeft = button.isConnectedOnLeft();
			const bool flatOnRight = button.isConnectedOnRight();
			const bool flatOnTop = button.isConnectedOnTop();
			const bool flatOnBottom = button.isConnectedOnBottom();

			const float width = button.getWidth() - 1.0f;
			const float height = button.getHeight() - 1.0f;

			if (width > 0 && height > 0)
			{
				const float cornerSize = 4.0f;

				Path outline;
				outline.addRoundedRectangle (0.5f, 0.5f, width, height, cornerSize, cornerSize,
											 ! (flatOnLeft || flatOnTop),
											 ! (flatOnRight || flatOnTop),
											 ! (flatOnLeft || flatOnBottom),
											 ! (flatOnRight || flatOnBottom));

				drawButtonShape (g, outline, baseColour, height);
			}
		}
		static void drawButtonShape (Graphics& g, const Path& outline, Colour baseColour, float height)
		{
			g.setColour (baseColour);
			g.fillPath (outline);
			g.strokePath (outline, PathStrokeType (1.0f), AffineTransform::translation (0.0f, 1.0f)
						  .scaled (1.0f, (height - 1.6f) / height));
			g.strokePath (outline, PathStrokeType (1.0f));
		}
		Font getTextButtonFont (TextButton&, int buttonHeight) override
		{
			return Font (buttonHeight / 1.6f);
		}

		Typeface::Ptr getTypefaceForFont (const Font&)
		{
			return robotoTypeFace;
		}

		Typeface::Ptr robotoTypeFace;
};

#endif  // CUSTOMLOOK_H_INCLUDED
