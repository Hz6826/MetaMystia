using System;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Common.UI
{
	// Token: 0x02000360 RID: 864
	public class ITextProvider<TLanguageBase> : Il2CppObjectBase where TLanguageBase : LanguageBase
	{
		// Token: 0x060065F3 RID: 26099 RVA: 0x001F2EA0 File Offset: 0x001F10A0
		// Note: this type is marked as 'beforefieldinit'.
		static ITextProvider()
		{
			Il2CppClassPointerStore<ITextProvider<TLanguageBase>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "ITextProvider`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLanguageBase>.NativeClassPtr))
			})).TypeHandle.value);
			ITextProvider<TLanguageBase>.NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_TLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITextProvider<TLanguageBase>>.NativeClassPtr, 100684657);
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x001F2F18 File Offset: 0x001F1118
		public unsafe virtual TLanguageBase Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITextProvider<TLanguageBase>.NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_TLanguageBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TLanguageBase>(intPtr, false, true);
			}
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x00037143 File Offset: 0x00035343
		public ITextProvider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040043A0 RID: 17312
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_TLanguageBase_0;
	}
}
