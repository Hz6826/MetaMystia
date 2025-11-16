using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200030A RID: 778
	public class DecorationBase : ScriptableObject
	{
		// Token: 0x06005D08 RID: 23816 RVA: 0x001D3FC8 File Offset: 0x001D21C8
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationBase()
		{
			Il2CppClassPointerStore<DecorationBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationBase>.NativeClassPtr);
			DecorationBase.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_New_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationBase>.NativeClassPtr, 100682485);
			DecorationBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationBase>.NativeClassPtr, 100682486);
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x001D4020 File Offset: 0x001D2220
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecorationBase.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_New_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x001D4070 File Offset: 0x001D2270
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x00032C88 File Offset: 0x00030E88
		public DecorationBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D97 RID: 15767
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_New_Void_EventManager_0;

		// Token: 0x04003D98 RID: 15768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
