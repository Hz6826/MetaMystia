using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000F7 RID: 247
	public class DLC5_RogueLikeCardPersistentSlaanesh : RogueLikeCardPersistent
	{
		// Token: 0x06001B63 RID: 7011 RVA: 0x000FA568 File Offset: 0x000F8768
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentSlaanesh()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentSlaanesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentSlaanesh.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr, 100668256);
			DLC5_RogueLikeCardPersistentSlaanesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr, 100668257);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000FA5C0 File Offset: 0x000F87C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72309, XrefRangeEnd = 72346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentSlaanesh.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000FA640 File Offset: 0x000F8840
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentSlaanesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentSlaanesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00010B7D File Offset: 0x0000ED7D
		public DLC5_RogueLikeCardPersistentSlaanesh(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006BC RID: 1724
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentSlaanesh+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06009915 RID: 39189 RVA: 0x0028DB64 File Offset: 0x0028BD64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeFieldInfoPtr_removeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr, "removeCallback");
				DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr, 100668258);
				DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr, 100668259);
				DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr, 100668260);
			}

			// Token: 0x06009916 RID: 39190 RVA: 0x0028DBF4 File Offset: 0x0028BDF4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009917 RID: 39191 RVA: 0x0028DC30 File Offset: 0x0028BE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72305, XrefRangeEnd = 72309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CardEffectBeforeWorking_b__0(ValueTuple<Recipe, Sellable> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009918 RID: 39192 RVA: 0x0028DC84 File Offset: 0x0028BE84
			[CallerCount(0)]
			public unsafe void _CardEffectBeforeWorking_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeMethodInfoPtr__CardEffectBeforeWorking_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009919 RID: 39193 RVA: 0x00052D63 File Offset: 0x00050F63
			public __c__DisplayClass0_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032D6 RID: 13014
			// (get) Token: 0x0600991A RID: 39194 RVA: 0x0028DCB8 File Offset: 0x0028BEB8
			// (set) Token: 0x0600991B RID: 39195 RVA: 0x00052D6C File Offset: 0x00050F6C
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D7 RID: 13015
			// (get) Token: 0x0600991C RID: 39196 RVA: 0x0028DCE8 File Offset: 0x0028BEE8
			// (set) Token: 0x0600991D RID: 39197 RVA: 0x00052D8B File Offset: 0x00050F8B
			public unsafe Action removeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeFieldInfoPtr_removeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentSlaanesh.__c__DisplayClass0_0.NativeFieldInfoPtr_removeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400631F RID: 25375
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x04006320 RID: 25376
			private static readonly IntPtr NativeFieldInfoPtr_removeCallback;

			// Token: 0x04006321 RID: 25377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006322 RID: 25378
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_Internal_Boolean_ValueTuple_2_Recipe_Sellable_0;

			// Token: 0x04006323 RID: 25379
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__2_Internal_Void_0;
		}

		// Token: 0x020006BD RID: 1725
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardPersistentSlaanesh+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600991E RID: 39198 RVA: 0x0028DD18 File Offset: 0x0028BF18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr);
				DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr, "<>9__0_1");
				DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr, 100668262);
				DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr, 100668263);
			}

			// Token: 0x0600991F RID: 39199 RVA: 0x0028DD94 File Offset: 0x0028BF94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentSlaanesh.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009920 RID: 39200 RVA: 0x0028DDD0 File Offset: 0x0028BFD0
			[CallerCount(0)]
			public unsafe string _CardEffectBeforeWorking_b__0_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009921 RID: 39201 RVA: 0x00052DAA File Offset: 0x00050FAA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032D8 RID: 13016
			// (get) Token: 0x06009922 RID: 39202 RVA: 0x0028DE18 File Offset: 0x0028C018
			// (set) Token: 0x06009923 RID: 39203 RVA: 0x00052DB3 File Offset: 0x00050FB3
			public unsafe static DLC5_RogueLikeCardPersistentSlaanesh.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardPersistentSlaanesh.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032D9 RID: 13017
			// (get) Token: 0x06009924 RID: 39204 RVA: 0x0028DE40 File Offset: 0x0028C040
			// (set) Token: 0x06009925 RID: 39205 RVA: 0x00052DC5 File Offset: 0x00050FC5
			public unsafe static Func<string, string> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardPersistentSlaanesh.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006324 RID: 25380
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006325 RID: 25381
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04006326 RID: 25382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006327 RID: 25383
			private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__0_1_Internal_String_String_0;
		}
	}
}
