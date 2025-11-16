using System;
using DayScene.UI;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A8 RID: 680
	[Serializable]
	public class KyoukoTutorialData_FreshManTip : KyoukoTutorialDataContainsTimeline
	{
		// Token: 0x06005612 RID: 22034 RVA: 0x001C09F8 File Offset: 0x001BEBF8
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_FreshManTip()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_FreshManTip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip>.NativeClassPtr);
			KyoukoTutorialData_FreshManTip.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip>.NativeClassPtr, 100680827);
			KyoukoTutorialData_FreshManTip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip>.NativeClassPtr, 100680828);
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x001C0A50 File Offset: 0x001BEC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214021, XrefRangeEnd = 214042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_FreshManTip.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x001C0AA0 File Offset: 0x001BECA0
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_FreshManTip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_FreshManTip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x0002E574 File Offset: 0x0002C774
		public KyoukoTutorialData_FreshManTip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0;

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C60 RID: 3168
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_FreshManTip+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600E473 RID: 58483 RVA: 0x0036F058 File Offset: 0x0036D258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr);
				KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr, 100680829);
				KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr, 100680830);
			}

			// Token: 0x0600E474 RID: 58484 RVA: 0x0036F0D4 File Offset: 0x0036D2D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E475 RID: 58485 RVA: 0x0036F110 File Offset: 0x0036D310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214015, XrefRangeEnd = 214021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractDialogPackageClose_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E476 RID: 58486 RVA: 0x00079DF3 File Offset: 0x00077FF3
			public __c__DisplayClass0_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A1D RID: 18973
			// (get) Token: 0x0600E477 RID: 58487 RVA: 0x0036F144 File Offset: 0x0036D344
			// (set) Token: 0x0600E478 RID: 58488 RVA: 0x00079DFC File Offset: 0x00077FFC
			public unsafe KyoukoTutorialData_FreshManTip __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_FreshManTip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A1E RID: 18974
			// (get) Token: 0x0600E479 RID: 58489 RVA: 0x0036F174 File Offset: 0x0036D374
			// (set) Token: 0x0600E47A RID: 58490 RVA: 0x00079E1B File Offset: 0x0007801B
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_FreshManTip.__c__DisplayClass0_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091FB RID: 37371
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091FC RID: 37372
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091FD RID: 37373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091FE RID: 37374
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__0_Internal_Void_0;
		}
	}
}
