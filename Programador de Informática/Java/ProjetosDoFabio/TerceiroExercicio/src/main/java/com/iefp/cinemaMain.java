package com.iefp;


import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@SpringBootApplication
@ComponentScan(basePackages = {"com.iefp"})
public class cinemaMain {

	public static void main(String[] args) {
		SpringApplication.run(cinemaMain.class, args);
		
		
		
	}

}
