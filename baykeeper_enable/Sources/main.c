#include"fsl_device_registers.h"
#include "board.h"
#include "pin_mux.h"
#include "fsl_clock_manager.h"
#include "fsl_debug_console.h"
#include <stdio.h>

int main(void)
{
	/* enable clock for PORTs */

	CLOCK_SYS_EnablePortClock(PORTA_IDX);
	CLOCK_SYS_EnablePortClock(PORTB_IDX);
	CLOCK_SYS_EnablePortClock(PORTC_IDX);
	CLOCK_SYS_EnablePortClock(PORTE_IDX);

	/* Init board clock */

	BOARD_ClockInit();

	// initialize the GPIO interrupt for push button for falling edge

	switchPins[0].config.interrupt = kPortIntRisingEdge;
	switchPins[1].config.interrupt = kPortIntRisingEdge;

	// Initializes GPIO driver

	GPIO_DRV_Init(switchPins, ledPins);
	GPIO_DRV_ClearPinOutput(kGpioPTA1); // Toggle blue LED
	GPIO_DRV_ClearPinOutput(BOARD_GPIO_LED_BLUE); // Toggle blue LED

	while(1)
	{
	}
	return 0;
} //end of main

// Define PORTC_IRQHandler (sw1) if GPIO_INTERRUPT is set

void PORTA_IRQHandler()
{
	GPIO_DRV_ClearPinIntFlag (kGpioPTA2); // Clear IRQ flag
	GPIO_DRV_SetPinOutput(kGpioPTA1); // Toggle blue LED
	GPIO_DRV_SetPinOutput(BOARD_GPIO_LED_BLUE); // Toggle blue LED
}

void PORTC_IRQHandler()
{
	unsigned int i;
	for (i=0; i < 1075; i++) {
		// skip CPU cycle or any other statement(s) for making loop
		// untouched by C compiler code optimizations
		//asm("nop");
	}


	GPIO_DRV_ClearPinIntFlag (kGpioPTC3); // Clear IRQ flag
	GPIO_DRV_ClearPinOutput(kGpioPTA1); // Toggle blue LED
	GPIO_DRV_ClearPinOutput(BOARD_GPIO_LED_BLUE); // Toggle blue LED
}


