class_name Main_Menu
extends Control

@onready var start_button = $MarginContainer/VBoxContainer/Button as Button
@onready var option_button = $MarginContainer/VBoxContainer/Button2 as Button
@onready var option_menu = $Option_Menu as OptionMenu
@onready var exit_button = $MarginContainer/VBoxContainer/Button3 as Button
@onready var margin_container = $MarginContainer as MarginContainer
# @onready var start_level = preload() // load scene 1 cua man hinh game


func _ready():
	handle_connecting_signals()

func on_start_pressed() -> void:
	print("button pressed")

func on_option_pressed() -> void:
	margin_container.visible = false
	option_menu.set_process(true)
	option_menu.visible = true

func on_exit_pressed() -> void:
	get_tree().quit()

func on_exit_option_menu() -> void:
	margin_container.visible = true
	option_menu.visible = false

func handle_connecting_signals() -> void:
	start_button.button_down.connect(on_start_pressed)
	option_button.button_down.connect(on_option_pressed)
	exit_button.button_down.connect(on_exit_pressed)
	option_menu.exit_option_menu.connect(on_exit_option_menu)
