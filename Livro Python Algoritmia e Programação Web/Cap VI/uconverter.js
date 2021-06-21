conversion_map =
    {
    "Polegadas Centimetros":1.0/2.54,
    "Centimetros Polegadas":2.54
    };
$("button").button().click(function() {
    value=$("input[name='num1']").val();
    f = $("select[name='unidade2'] option:selected").val();
    t = $("select[name='unidade1'] option:selected").val();
    if (f != t) {
        c = conversion_map[f + ' ' + t];
        result = parseFloat(value) * c;
    } else {
        result = value;
    }
    $("input[name='num2']").val(result);
}
);
$("form *").addClass("ui-widget");
