using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000252 RID: 594
	public class KoishiFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A23 RID: 18979 RVA: 0x001A0F30 File Offset: 0x0019F130
		// Note: this type is marked as 'beforefieldinit'.
		static KoishiFoodEasterEggData()
		{
			Il2CppClassPointerStore<KoishiFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "KoishiFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KoishiFoodEasterEggData>.NativeClassPtr);
			KoishiFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KoishiFoodEasterEggData>.NativeClassPtr, 100678242);
			KoishiFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KoishiFoodEasterEggData>.NativeClassPtr, 100678243);
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x001A0F88 File Offset: 0x0019F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193840, XrefRangeEnd = 193848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastOrder);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toEval);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldResult;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalResult;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KoishiFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x001A102C File Offset: 0x0019F22C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KoishiFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KoishiFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KoishiFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00025DD9 File Offset: 0x00023FD9
		public KoishiFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEE RID: 2798
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.KoishiFoodEasterEggData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D074 RID: 53364 RVA: 0x003336D4 File Offset: 0x003318D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KoishiFoodEasterEggData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr);
				KoishiFoodEasterEggData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr, "<>9");
				KoishiFoodEasterEggData.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr, "<>9__0_0");
				KoishiFoodEasterEggData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr, 100678245);
				KoishiFoodEasterEggData.__c.NativeMethodInfoPtr__CheckEasterEgg_b__0_0_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr, 100678246);
			}

			// Token: 0x0600D075 RID: 53365 RVA: 0x00333750 File Offset: 0x00331950
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KoishiFoodEasterEggData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KoishiFoodEasterEggData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D076 RID: 53366 RVA: 0x0033378C File Offset: 0x0033198C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193837, XrefRangeEnd = 193840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CheckEasterEgg_b__0_0(GuestGroupController koishi)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(koishi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KoishiFoodEasterEggData.__c.NativeMethodInfoPtr__CheckEasterEgg_b__0_0_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D077 RID: 53367 RVA: 0x0006FA07 File Offset: 0x0006DC07
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D4 RID: 17364
			// (get) Token: 0x0600D078 RID: 53368 RVA: 0x003337D0 File Offset: 0x003319D0
			// (set) Token: 0x0600D079 RID: 53369 RVA: 0x0006FA10 File Offset: 0x0006DC10
			public unsafe static KoishiFoodEasterEggData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KoishiFoodEasterEggData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KoishiFoodEasterEggData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KoishiFoodEasterEggData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D5 RID: 17365
			// (get) Token: 0x0600D07A RID: 53370 RVA: 0x003337F8 File Offset: 0x003319F8
			// (set) Token: 0x0600D07B RID: 53371 RVA: 0x0006FA22 File Offset: 0x0006DC22
			public unsafe static Action<GuestGroupController> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KoishiFoodEasterEggData.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KoishiFoodEasterEggData.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008605 RID: 34309
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008606 RID: 34310
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04008607 RID: 34311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008608 RID: 34312
			private static readonly IntPtr NativeMethodInfoPtr__CheckEasterEgg_b__0_0_Internal_Void_GuestGroupController_0;
		}
	}
}
