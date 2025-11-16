using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B1 RID: 689
	[Serializable]
	public class KyoukoTutorialData_SpellCard : KyoukoTutorialData
	{
		// Token: 0x06005654 RID: 22100 RVA: 0x001C164C File Offset: 0x001BF84C
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_SpellCard()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_SpellCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_SpellCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard>.NativeClassPtr);
			KyoukoTutorialData_SpellCard.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard>.NativeClassPtr, 100680867);
			KyoukoTutorialData_SpellCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard>.NativeClassPtr, 100680868);
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x001C16A4 File Offset: 0x001BF8A4
		public unsafe override bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214365, XrefRangeEnd = 214388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_SpellCard.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x001C16EC File Offset: 0x001BF8EC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_SpellCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_SpellCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x0002E777 File Offset: 0x0002C977
		public KyoukoTutorialData_SpellCard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040039DD RID: 14813
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0;

		// Token: 0x040039DE RID: 14814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C68 RID: 3176
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_SpellCard+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E4D2 RID: 58578 RVA: 0x0036FF14 File Offset: 0x0036E114
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr);
				KyoukoTutorialData_SpellCard.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr, "<>9");
				KyoukoTutorialData_SpellCard.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr, "<>9__1_0");
				KyoukoTutorialData_SpellCard.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr, 100680870);
				KyoukoTutorialData_SpellCard.__c.NativeMethodInfoPtr__get_NeedToShow_b__1_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr, 100680871);
			}

			// Token: 0x0600E4D3 RID: 58579 RVA: 0x0036FF90 File Offset: 0x0036E190
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_SpellCard.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_SpellCard.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4D4 RID: 58580 RVA: 0x0036FFCC File Offset: 0x0036E1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214361, XrefRangeEnd = 214365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_NeedToShow_b__1_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_SpellCard.__c.NativeMethodInfoPtr__get_NeedToShow_b__1_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E4D5 RID: 58581 RVA: 0x0007A1F8 File Offset: 0x000783F8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A3A RID: 19002
			// (get) Token: 0x0600E4D6 RID: 58582 RVA: 0x00370018 File Offset: 0x0036E218
			// (set) Token: 0x0600E4D7 RID: 58583 RVA: 0x0007A201 File Offset: 0x00078401
			public unsafe static KyoukoTutorialData_SpellCard.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialData_SpellCard.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_SpellCard.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialData_SpellCard.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A3B RID: 19003
			// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x00370040 File Offset: 0x0036E240
			// (set) Token: 0x0600E4D9 RID: 58585 RVA: 0x0007A213 File Offset: 0x00078413
			public unsafe static Func<int, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialData_SpellCard.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialData_SpellCard.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400922B RID: 37419
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400922C RID: 37420
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x0400922D RID: 37421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400922E RID: 37422
			private static readonly IntPtr NativeMethodInfoPtr__get_NeedToShow_b__1_0_Internal_Boolean_Int32_0;
		}
	}
}
